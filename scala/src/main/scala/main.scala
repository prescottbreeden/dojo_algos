object Main extends App {

  def sigma(num: Int): Int = {
    if (num <= 0) num
    else num + sigma(num-1)
  }

  def isPalindrome(s: String) = {
    val test: String = s.toLowerCase()
    def palHelper(test: String, start: Int, end: Int): Boolean = {
      if ((end - start) <= 1) true
      else if (test.charAt(start) != test.charAt(end)) false
      else palHelper(test, start + 1, end - 1)
    }
    palHelper(test, 0, test.length-1)
  }

  def fibonacci(num: Int): Int = {
    if (num <= 1) num
    else fibonacci(num - 1) + fibonacci(num - 2)
  }




  println("============================")
  println("         TEST CODE          ")
  println("============================")
  println(sigma(19))
  println(isPalindrome("bobba"))
  println(fibonacci(5))

}