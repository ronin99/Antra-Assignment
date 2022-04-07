function checkEmailId(str) {
    let regex = new RegExp('[a-z0-9]+@[a-z]+\.[a-z]{2,3}');
    return regex.test(str)
}
console.log(checkEmailId("123@gmail.com"));
console.log(checkEmailId("123@.com"));