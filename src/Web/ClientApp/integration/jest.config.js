module.exports = {
    preset: 'jest-puppeteer',
    testRegex: './*\\.test\\.js$',
    transform: {
        "^.+\\.js$": "babel-jest",
        ".+\\.(css|styl|less|sass|scss)$": "jest-transform-css"
    },
    setupFiles: [
        "<rootDir>/../node_modules/regenerator-runtime/runtime"
    ]
}