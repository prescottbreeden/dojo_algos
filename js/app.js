'use strict'
const sorts = require('./algorithms/sorts');
const sll = require('./dataStructures/sll');
const hash = require('./dataStructures/hash');

let bad = [6, 4, 3, 8, 6, 4, 2, 8, 1];
sorts.quickSort(bad);
console.log(bad);