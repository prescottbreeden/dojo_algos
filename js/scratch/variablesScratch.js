function double(num) {
  num *= 2;
}

function doubleObject(obj) {
  obj.val *= 2;
}

function concat(str) {
  return str += ' ' + str;
}

function concatObject(obj) {
  obj.str += ' ' + obj.str;
}

const bob = { val: 5, str: "bob ross" };

console.log(bob);

console.log('double bob.val');
double(bob.val);
console.log(bob);

console.log('double bob');
doubleObject(bob);
console.log(bob);


console.log('\n ------------------------ \n');

console.log('concat bob.str');
bob.str = concat(bob.str);
console.log(bob);

console.log('concat bob');
concatObject(bob);
console.log(bob);
