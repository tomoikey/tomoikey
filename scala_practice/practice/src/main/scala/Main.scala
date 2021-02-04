object Main extends App {

  /*関数の省略（簡潔になりすぎてびっくりしないように）*/

  val originFunc: Function1[Int, String] = new Function1[Int, String] {
    def apply(args: Int):String ={
      return args.toString
    }
  }

  val f: (Int) => String = _.toString //Function 0 ~ 23の場合このように書ける(Function1 引数1個)
//  println(f(10)) //"10"

  val g:(Int, Int) => String = (a, b) => a.toString + b.toString //(Function2)
//  println(g(1,2)) //"12"


  /*パターンマッチング無名関数*/

  val pf: PartialFunction[Int, String] = {
    case 1 => "AAA"
    case 2 => "BBB"
    case _ => "not match"
  }
//  println(pf(1)) //"AAA"

  val sq = Seq(1, 2, 3) map{
    case 1 => "AAA"
    case 2 => "BBB"
    case _ => "ZZZ"
  }
//  sq.map(a => println(a)) //"AAA" "BBB" "ZZZ"


  /*メソッドから関数生成*/
  def add(a: Int, b: Int): Int = a + b

  val h = add _ //h: (Int, Int) => Int = (a, b) => a + b と同義
  val i: (Int, Int) => Int = add //このように書けば上記のhと同じ意味
//  println(add(1, 2)) //3
//  println(h(1, 2))   //3
//  println(i(1, 2))   //3
}