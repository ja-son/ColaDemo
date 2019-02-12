// jest-puppeteer.config.js
const port = process.env.TEST_SERVER_PORT
    ? Number(process.env.TEST_SERVER_PORT)
    : 3000

process.env.TEST_SERVER_PORT = port

module.exports = {
    launch: {
        //dumpio: true,
        slowMo: 500,
        headless: process.env.HEADLESS !== 'false',
    },
    browserContext: 'default',
    server: {
        command: 'npm start',
        port: port,
        launchTimeout: 60000,
        debug: true
    }
}