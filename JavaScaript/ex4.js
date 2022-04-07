function truncate(str, maxlen) {
    str = str.substring(0, maxlen);
    str += "...";
    console.log(str);
}

let str = "What I'd like to tell on this topic is:";
let size = 20;

console.log(str);
truncate(str, size);