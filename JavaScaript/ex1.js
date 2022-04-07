let salaries = {
    john: 100,
    Ann: 160,
    Pete: 130
};

function sumObjects() {
    let size = Object.keys(salaries).length;
    let sum = 0;
    for (var i = 0; i < size; i++) {
        sum = sum + Object.values(salaries)[i];
    }
    return sum;
}

console.log(sumObjects());