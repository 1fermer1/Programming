import java.util.Scanner;

public class Program {
	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);

		System.out.print("input first integer number: ");
		int a = in.nextInt();
		System.out.print("input second integer number: ");
		int b = in.nextInt();
		System.out.printf("biggest common divisor %d and %d = %d", a, b, EuclideanAlgorithm(a, b));
	}

	static int EuclideanAlgorithm(int a, int b) {
		if (a % b == 0) return b;
		return EuclideanAlgorithm(b, a % b);
	}
}