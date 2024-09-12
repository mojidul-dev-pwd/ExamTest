using ExamTest;

Console.WriteLine("Hello, Mojidul!");

int[,,,] array1 = new int[2, 2, 2, 2] {
 {
 {{1, 2}, {3, 4}},
 {{5, 6}, {7, 8}}
 },
 {
 {{9, 10}, {11, 12}},
 {{13, 14}, {15, 16}}
 }
};
int[,,,] array2 = new int[2, 2, 2, 2] {
 {
 {{5, 2}, {13, 14}},
 {{9, 6}, {20, 8}}
 },
 {
 {{3, 10}, {21, 4}},
 {{25, 16}, {7, 1}}
 }
};

int[,,,] array3 = new int[1, 1, 1, 3] { { { { 1, 2, 3 } } } };
int[,,,] array4 = new int[1, 1, 1, 3] { { { { 4, 5, 6 } } } };

int[,,,] array5 = new int[2, 2, 2, 1] {
 {
 {{1}, {2}},
 {{3}, {4}}
 },
 {
 {{5}, {6}},
 {{7}, {8}}
 }
};
int[,,,] array6 = new int[2, 2, 2, 1] {
 {
 {{1}, {2}},
 {{3}, {4}}
 },
 {
 {{5}, {6}},
 {{7}, {8}}
 }
};

int[,,,] array7 = new int[0, 0, 0, 0];
int[,,,] array8 = new int[0, 0, 0, 0];

int[,,,] array9 = new int[2, 2, 1, 2] {
 {
 {{1, 2}},
 {{3, 4}}
 },
 {
 {{5, 6}},
 {{7, 8}}
 }
};
int[,,,] array10 = new int[3, 2, 1, 2] {
 {
 {{5, 9}},
 {{3, 6}}
 },
 {
 {{7, 2}},
 {{8, 4}}
 },
 {
 {{10, 11}},
 {{1, 12}}
 }
};

int[,,,] array11 = new int[1, 1, 1, 5] { { { { 1, 2, 3, 4, 5 } } } };
int[,,,] array12 = new int[1, 1, 1, 6] { { { { 5, 4, 3, 2, 1, 0 } } } };

int[,,,] array13 = new int[3, 3, 3, 3];
int[,,,] array14 = new int[3, 3, 3, 3];
//Initialize both arrays with some large data
for (int i = 0; i < 3; i++)
    for (int j = 0; j < 3; j++)
        for (int k = 0; k < 3; k++)
            for (int l = 0; l < 3; l++)
            {
                array13[i, j, k, l] = i * j * k * l;
                array14[i, j, k, l] = i * j * k * l;
            }

var testCase1 = ProblemAndSolution.FindMatchingElements(array1, array2);
Console.WriteLine("[{0}]", string.Join(',', testCase1));

var testCase2 = ProblemAndSolution.FindMatchingElements(array3, array4);
Console.WriteLine("[{0}]", string.Join(',', testCase2));

var testCase3 = ProblemAndSolution.FindMatchingElements(array5, array6);
Console.WriteLine("[{0}]", string.Join(',', testCase3));

var testCase4 = ProblemAndSolution.FindMatchingElements(array7, array8);
Console.WriteLine("[{0}]", string.Join(',', testCase4));

var testCase5 = ProblemAndSolution.FindMatchingElements(array9, array10);
Console.WriteLine("[{0}]", string.Join(',', testCase5));

var testCase6 = ProblemAndSolution.FindMatchingElements(array11, array12);
Console.WriteLine("[{0}]", string.Join(',', testCase6));

var testCase7 = ProblemAndSolution.FindMatchingElements(array13, array14);
Console.WriteLine("[{0}]", string.Join(',', testCase7));

Console.WriteLine("Thank You!");
