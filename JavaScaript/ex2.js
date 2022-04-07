let menu = { width: 200, height: 300, title: "My menu" };

function multiplyNumeric(menu) {
    Object.keys(menu).forEach(key => {
        if (typeof menu[key] === 'number') {
            menu[key] = menu[key] * 2;
        }
    })

}
multiplyNumeric(menu);

console.log(Object.values(menu));