/**
 * Leetcode Problem of the day May 24, 2021
 * Given a string s, return the string after replacing all uppercase
 * letters with the same lowercase letter
 * @params s [string] : the string to be converted to all lowercase
 *
 * @return s [string] : All lowercase string
 */
// System used in the namespace on leetcode
// But to avoid confusion, I have included it here
using System;
public class Solution {
    // System includes the ToLower function for strings, that returns a copy of the string converted to lowercase
    // You can also provide an override for the CultureInfo that supplies culture specific casing rules
    // Useful for localization.
    public string ToLowerCase(string s) { return s.ToLower(); }
}