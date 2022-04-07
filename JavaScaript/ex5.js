let arr = ["James", "Brennie"];
arr.push("Robert");
console.log(arr);
/* arr.splice(arr.length / 2 | 0); */
arr[arr.length / 2 | 0] = "Calvin";
console.log(arr);
arr.shift();
console.log(arr);
arr.unshift("Rose", "Regal");
console.log(arr);