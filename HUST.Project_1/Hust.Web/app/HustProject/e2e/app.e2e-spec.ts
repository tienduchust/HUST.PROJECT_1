import { HustProjectPage } from './app.po';

describe('hust-project App', function() {
  let page: HustProjectPage;

  beforeEach(() => {
    page = new HustProjectPage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
