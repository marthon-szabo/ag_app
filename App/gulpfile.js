const { src, dest } = require('gulp');
const compileSass = require('gulp-sass');

compileSass.compiler = require('node-sass');
 
const watch = () => {
    return src('./wwwroot/sass/**/*.scss')
    .pipe(compileSass().on('error', compileSass.logError))
    .pipe(dest('./wwwroot/css'));
};

exports.watch = watch;
