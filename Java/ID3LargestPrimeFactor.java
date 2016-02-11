import java.util.ArrayList;
import java.util.List;

public class ID3LargestPrimeFactor {

    public static int largestPrimeFactor(long number) {
        List<Integer> primeFactors = new ArrayList<Integer>();

        for (int i = 2; i <= number; i++) {
            while (number % i == 0) {
                primeFactors.add(i);
                number /= i;
            }
        }

            return primeFactors.get(primeFactors.size() - 1);
    }

    public static void main(String[] args) {
        System.out.println("Answer is  " + largestPrimeFactor(600851475143L));
    }
}