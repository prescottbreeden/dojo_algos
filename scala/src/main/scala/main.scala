import scala.annotation.tailrec
object Main extends App {

  def sigma(num: Int): Int = {
    if (num <= 0) num
    else num + sigma(num-1)
  }

  def fibonacci(num: Int): Int = {
    if (num <= 1) num
    else fibonacci(num - 1) + fibonacci(num - 2)
  }

  def fibTail(n: Long): Long = {
    if (n <= 1) n

    @tailrec
    def fibHelper(a: Long, b: Long, n: Long): Long = {
      if (n == 0) b
      else fibHelper(b, a + b, n-1)
    }
    fibHelper(1, 1, n-2)
  }


  def isPalindrome(s: String) = {
    val test: String = s.toLowerCase()

    @tailrec
    def palHelper(test: String, start: Int, end: Int): Boolean = {
      if ((end - start) <= 1) true
      else if (test.charAt(start) != test.charAt(end)) false
      else palHelper(test, start + 1, end - 1)
    }
    palHelper(test, 0, test.length-1)
  }

  def isPrime(n: Int): Boolean = {

    @tailrec
    def isPrimeUntil(t: Int): Boolean = {
      if (t <= 1) true
      else n % t != 0 && isPrimeUntil(t-1)
    }
    isPrimeUntil(n / 2)
  }




  println("============================")
  println("         TEST CODE          ")
  println("============================")
  println(sigma(19))
  println(isPalindrome("bobba"))
  println(fibonacci(12))
  println(fibTail(50))
  println(isPrime(11))
  println(isPrime(11 * 4))

}