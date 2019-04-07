'use strict'
module.exports = HashMap;

function HashMap(capacity) {
  this.capacity = capacity;
  this.table = [];
}

HashMap.prototype.hashCode = function(string) {
  var hash = 0;
  if (string.length == 0) return hash;
  for (let i = 0; i < string.length; i++) {
    let char = string.charCodeAt(i);
    hash = ((hash << 5) - hash) + char;
    hash &= hash;
  }
  return hash;
}

function mod(input, div) {
  return (input % div + div) % div;
}

HashMap.prototype.add = function(string) {
  let idx = mod(string, this.capacity);
  this.table[idx] = string;
}

HashMap.prototype.get = function(string) {
  let idx = mod(string, this.capacity);
  return this.table[idx];
}