import expectPuppeteer from 'expect-puppeteer';

describe('App', () => {
    beforeEach(async () => {
        page.emulate({
            viewport: {
                width: 1024,
                height: 2400
            },
            userAgent: ''
        });

        await page.goto(`http://localhost:${process.env.TEST_SERVER_PORT}/`);
    });

    describe('Questions', () => {
    
        it('should load H1 correctly', async () => {
            await expect(page).toMatch('Hello, world!', { timeout: 6000 });
        }, 10000);

        it('should click questions link', async () => {
            await expect(page).toClick('a[href="/questions"]');
            await page.waitForSelector('html');
            const pathname = await page.evaluate(() => document.location.pathname);
            await expect(pathname).toBe('/questions');
            await expect(page).toMatch('All Questions');
            
        }, 10000);

        it('should render questions', async () => {
            await expect(page).toMatch('Dynamically assign value to a Property', { timeout: 8000 });
        }, 10000);
    });
});