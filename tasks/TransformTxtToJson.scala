object Main extends App {
  val file = io.Source.fromFile(args(0))

  println("[")
  file.getLines foreach {
    line => 
      val splitted = line.split("\\s+")
      println(s"""  {"question": "Яка столиця країни ${splitted(0)}?", "answer": "${splitted(2)}"},""")
  }

  println("]")
}
