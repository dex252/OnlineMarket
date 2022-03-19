const BURGER_MENU_BUTTON = '#burger-button-catalog';
const BURGER_MENU = '#header-burger-menu';
$(async () => {
    let burgerMenu = $(BURGER_MENU_BUTTON);
    let overlay = $(BURGER_MENU);
    burgerMenu.on('click', () => {
        if(burgerMenu.hasClass("change")){
            burgerMenu.removeClass("change");
        } else{
            burgerMenu.addClass("change");
        }

        //TODO: разгребсти кучу
        overlay.toggle("overlay");
    });
});