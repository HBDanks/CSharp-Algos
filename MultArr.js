/**
 * arrayOfMultiples
 * 
 * Creates an array where each index is equal to the value of the index multiplied
 * by the provided number.
 * 
 * @param {int} num - The number by which to multiply each index
 * @param {int} len - The length of the desired array
 * 
 * @returns Array
 */
const arrayOfMultiples = (num, len) => Array.from({length: len}, (x, i) => i*num);

// While this problem is not solved in C#, it was a question asked on LinkedIn
// that I knew how to solve using System.Linq and wanted to solve in a similar way
// Using JavaScript, this is the solution I came up with