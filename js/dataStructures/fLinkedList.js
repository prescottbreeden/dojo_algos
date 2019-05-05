function Node(ele, n = null) {
  return {
    value: ele,
    next: n
  }
}

function LinkedList(h = null) {
  return { head: h }
}

function AddFront(ele, list) {
  if (list.head) {
    return {
      head: Node(ele, list.head)
    }
  } else {
    return {
      head: Node(ele)
    }
  }
}

const bob = LinkedList()
console.log(bob)
const bob2 = AddFront(3, bob)
const bob3 = AddFront(2, bob2)
const bob4 = AddFront(1, bob3)
console.log(bob4)