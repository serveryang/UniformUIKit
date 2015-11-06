/// <binding Clean='clean' />

var gulp = require("gulp"),
    rimraf = require("rimraf"),
    concat = require("gulp-concat"),
    cssmin = require("gulp-cssmin"),
    uglify = require("gulp-uglify"),
    project = require("./project.json");

var paths = {
    webroot: "./" + project.webroot + "/",
    lib: "./wwwroot/lib/",
    login: {
        js: "./wwwroot/login/js/",
        css: "./wwwroot/login/css/"
    }
};

paths.js = paths.webroot + "js/**/*.js";
paths.minJs = paths.webroot + "js/**/*.min.js";
paths.css = paths.webroot + "css/**/*.css";
paths.minCss = paths.webroot + "css/**/*.min.css";
paths.concatJsDest = paths.webroot + "js/site.min.js";
paths.concatCssDest = paths.webroot + "css/site.min.css";

gulp.task("clean:js", function (cb) {
    rimraf(paths.concatJsDest, cb);
});

gulp.task("clean:css", function (cb) {
    rimraf(paths.concatCssDest, cb);
});

gulp.task("clean", ["clean:js", "clean:css"]);

gulp.task("min:js", function () {
    gulp.src([paths.js, "!" + paths.minJs], { base: "." })
        .pipe(concat(paths.concatJsDest))
        .pipe(uglify())
        .pipe(gulp.dest("."));
});

gulp.task("min:css", function () {
    gulp.src([paths.css, "!" + paths.minCss])
        .pipe(concat(paths.concatCssDest))
        .pipe(cssmin())
        .pipe(gulp.dest("."));
});

gulp.task("min", ["min:js", "min:css"]);

gulp.task("default", function () {
    console.log('this is default task!');
});

gulp.task("login.min.js", function () {
    var srcLoginJs = [
        paths.webroot + "login/js/jquery-1.9.1.js",
        paths.webroot + "login/js/jquery.icheck.js",
        paths.webroot + "login/js/bootstrap.js",
        paths.webroot + "login/js/modernizr.js",
        paths.webroot + "login/js/placeholders.min.j",
        paths.webroot + "login/js/respond.src.js",
        paths.webroot + "login/js/waypoints.min.js",
        paths.webroot + "login/js/jquery.backstretch.js",
        paths.webroot + "login/js/login.js",
        paths.webroot + "lib/jquery-validation/jquery.validate.js",
        paths.webroot + "lib/jquery-validation-unobtrusive/jquery.validate.unobtrusive.js"
    ];

    gulp.src(srcLoginJs).pipe(concat("login.min.js")).pipe(gulp.dest(paths.login.js));
});

gulp.task("login.min.css", function () {
    var srcLoginCss = [
        paths.webroot + "login/css/font.css",
        paths.webroot + "login/css/preview.css",
        paths.webroot + "login/css/login.css",
    ];

    gulp.src(srcLoginCss).pipe(concat("login.min.css")).pipe(gulp.dest(paths.login.css));
});