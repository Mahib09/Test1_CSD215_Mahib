let salaries = [75000; 48000; 120000; 190000; 300113; 92000; 36000]
printfn "Base Salaries without Taxes: %A" salaries
let highIncomeSalaries = salaries |> List.filter (fun salary -> salary > 100000)
printfn "High-income salaries: %A" highIncomeSalaries

