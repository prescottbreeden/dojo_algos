class Node(num: Int, n: Node) {
  val value: Int = num
  var next: Node = n
}

class SLL(h: Node = null) {
  val head: Node = h
  def addFront(num: Int): SLL = new SLL(new Node(num, this.head))
  def removeFront(): SLL = new SLL(this.head.next)
}
