'use strict'

module.exports = {
  linkedList,
  node,
  printList,
  addToBack,
  addToFront,
  contains,
  size,
  removeDupes,
  reverse
}

function linkedList() {
  return {
    head: null,
  }
}

function node(val) {
  return {
    value: val,
    next: null
  }
}

function printList(sll) {
  if (!sll.head) console.log('no data');
  let runner = sll.head;
  while (runner) {
    console.log(runner.value)
    runner = runner.next;
  }
}

function size(node) {
  if(!node) return 0;
  return 1 + size(node.next);
}

function addToBack(sll, val) {
  if (!sll.head) 
    return sll.head = node(val);
  let runner = sll.head;
  while (runner.next) {
    runner = runner.next;
  }
  return runner.next = node(val);
}

function addToFront(sll, val) {
  if (!sll.head)
    return sll.head = node(val);
  let temp = sll.head;
  sll.head = node(val);
  sll.head.next = temp;
}

function contains(sll, val) {
  let runner = sll.head;
  while (runner) {
    if (runner.value === val) return true;
    runner = runner.next;
  }
  return false;
}

function removeDupes(sll) {
  let seen = {};
  let prev = null;
  let current = sll.head;
  while (current) {
    if (seen[JSON.stringify(current.value)]) {
      prev.next = current.next;
    } else {
      seen[JSON.stringify(current.value)] = JSON.stringify(current.value);
      prev = current;
    }
    current = prev.next;
  }
}

function reverse(sll) {
  let prev = null;
  let current = sll.head;
  let next = sll.head.next;
  while (next) {
    current.next = prev;
    prev = current;
    current = next;
    next = current.next;
  }
  current.next = prev;
  sll.head = current;
}