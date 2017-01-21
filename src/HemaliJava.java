import org.junit.Test;

import static org.junit.Assert.assertEquals;

public class HemaliJava {

    static int stringToInteger(String str) {
        int result = 0;
        int multiplier = 1;
        for (int i = str.length() - 1; i >= 0; i--) {
            int digit = str.charAt(i) - '0';
            if (digit < 0 || digit > 9) {
                throw new IllegalArgumentException("Invalid digit " + str.charAt(i) + " in input " + str);
            }
            result += (digit * multiplier);
            multiplier *= 10;
        }
        return result;
    }

    @Test
    public void stringToIntegerTest() throws Exception {
        assertEquals(134, stringToInteger("134"));
    }

    @Test(expected = IllegalArgumentException.class)
    public void stringToIntegerInvalidInputTest() throws Exception {
        stringToInteger("abc");
    }
}
