'use strict'
const sorts = require('./sorts');
const sll = require('./sll');
const hash = require('./hash');

let bad = [6, 4, 3, 8, 6, 4, 2, 8, 1];
sorts.quickSort(bad);
console.log(bad);