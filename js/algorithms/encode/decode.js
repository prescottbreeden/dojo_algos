// "aabbbcccc" => "a2b3c4"

function encodeString(string) {
  let newStr = "";
  function encode(string, newStr, prev = '', count = 0, n = 0) {
    if (n === string.length) {
      newStr += prev;
      return newStr;
    }
    if (string[n] === prev) {
      count++;
    } else {
      prev = string[n];
      if (count > 1) {
        newStr += string[n];
        count = 1;
      } else {
        newStr += count;
        count = 1;
      }
    }
    return encode(string, newStr, prev, count, n + 1);
  }
  return encode(string, newStr);
}

function encode2(string) {
  let newStr = "";
  let current = "";
  let prev = "";
  let count = 1;
  let n = 0;
  while (n < string.length) {
    current = string[n]; 
    if (current === prev) { 
      count++; 
    } 
    else { 
      prev = current;
      if (count > 1) {
        newStr += prev + count;
        count = 1;
      } else {
        newStr += current;
        count = 1;
      }
    }
    n++;
  }
  return newStr;
}

let res = encode2("aabbbcccc");
console.log(res);