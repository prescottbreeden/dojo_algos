function rotateArray(arr, n) {
  if (n === 0) return arr;
  let temp = arr.pop();
  arr.splice(0, 0, temp);
  return rotateArray(arr, n-1);
}

let array = [1, 2, 3, 4];
let newArr = rotateArray(array, 4);
console.log(newArr);

let string = 'Rubber Baby Buggy Bumpers';


function rotateString(str, n) {
  if (n === 0) {
    return str;
  }
  let end = str.length - 1;
  let lastLetter = str[end];
  let newString = lastLetter + str.slice(0, end);
  return rotateString(newString, n-1);
}

let odd = rotateString(string, 5);
let odd2 = rotateString(string, 5);
console.log(odd);
console.log(odd2);