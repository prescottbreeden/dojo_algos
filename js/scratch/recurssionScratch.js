'use strict'

function factorial(n) {
  if (n === 1) return n
  else return n * factorial(n-1)
}

function factorial_with_tail(n) {
  function tail_rec(x, accumulator = 1) {
    if (x < 1) return accumulator
    return tail_rec(x - 1, x * accumulator);
  }
  return tail_rec(n);
}

// console.log(factorial_with_tail(50000));

function f2(n, result = 1) {
  if (n === 1) {
    return result;
  }
  const next = n * result;
  return f2(n-1, next);
}
// console.log(f2(5000));

// Towers of Hanoi
function printMove(from, to) {
  console.log(`move from ${from} to ${to}`);
}

function towers(n, from, to, spare) {
  if (n === 1) {
    printMove(from, to);
  }
  else {
    towers(n-1, from, spare, to);
    towers(1, from, to, spare);
    towers(n-1, spare, to, from);
  }
}

// towers(4, 'A', 'B', 's');

// palindromes
let anneMichaels = "Are we not drawn onward to new era";
let napoleon = "Able was I ere I saw Elba";
let tacocat = "taco cat";
let bobbob = "bob bob";
let bob = "bob law blog"

function isPalindrome(str) {
  str = str.toLowerCase();
  str = str.split(' ').join('');
  function palHelper(str, start=0, end=str.length-1) {
    if (end - start <= 1) return true;
    if (str[start] != str[end]) return false;
    return palHelper(str, start+1, end-1);
  }
  return palHelper(str);
}

console.log(isPalindrome(napoleon));
console.log(isPalindrome(anneMichaels));
console.log(isPalindrome(tacocat));
console.log(isPalindrome(bobbob));
console.log(isPalindrome(bob));