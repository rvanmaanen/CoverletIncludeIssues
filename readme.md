4 projects:

- Demo (Provides 3 dummy methods returning "Hello, World")
- Demo.Test (Contains unittests for Demo, resulting in 100% coverage for the Demo project)
- Demo2 (Provides 1 dummy method returning "Hello, World", appended with the result of 1 of the dummy methods from the Demo project so the endresult is "Hello, World Hello, World"
- Demo2.Test (Contains unittests for Demo2, resulint in 100% coverage for the Demo2 project and 33% coverage for the Demo project)

So:

```
"dotnet test Demo.Test /p:CollectCoverage=true" results in:

+--------+--------+--------+--------+
| Module | Line   | Branch | Method |
+--------+--------+--------+--------+
| Demo   | 100%   | 0%     | 100%   |
+--------+--------+--------+--------+

"dotnet test Demo2.Test /p:CollectCoverage=true" results in:

+--------+--------+--------+--------+
| Module | Line   | Branch | Method |
+--------+--------+--------+--------+
| Demo   | 33,3%  | 0%     | 33,3%  |
+--------+--------+--------+--------+
| Demo2  | 100%   | 0%     | 100%   |
+--------+--------+--------+--------+

"dotnet test Demo2.Test /p:CollectCoverage=true /p:Exclude="[Demo]*"" results in:

```+--------+--------+--------+--------+
| Module | Line   | Branch | Method |
+--------+--------+--------+--------+
| Demo2  | 100%   | 0%     | 100%   |
+--------+--------+--------+--------+

"dotnet test Demo2.Test /p:CollectCoverage=true /p:Include="[Demo2]*"" results in:

+--------+--------+--------+--------+
| Module | Line   | Branch | Method |
+--------+--------+--------+--------+
| Demo   | 33,3%  | 0%     | 33,3%  |
+--------+--------+--------+--------+
| Demo2  | 100%   | 0%     | 100%   |
+--------+--------+--------+--------+

What I expected from this last call is the following:

+--------+--------+--------+--------+
| Module | Line   | Branch | Method |
+--------+--------+--------+--------+
| Demo2  | 100%   | 0%     | 100%   |
+--------+--------+--------+--------+
```

