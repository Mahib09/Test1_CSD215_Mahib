let salaries = [75000; 48000; 120000; 190000; 300113; 92000; 36000]
printfn "Base Salaries without Taxes: %A" salaries
let listOfHighIncomeSalaries = salaries |> List.filter (fun salary -> salary > 100000)
printfn "High-income salaries: %A" listOfHighIncomeSalaries
let taxCalculation salary =
    match salary with
    | s when s <= 49020 -> int (float salary * 0.15) 
    | s when s <= 98040 -> int (float salary * 0.205)
    | s when s <= 151978 -> int (float salary * 0.26)
    | s when s <= 216511 -> int (float salary * 0.29)
    | _ -> int (float salary * 0.33)
let salaryWithoutTaxes = salaries |> List.map taxCalculation
printfn "Taxes for all salaries: %A" salaryWithoutTaxes 
let salariesAfterTax = List.map2 (+) salaries salaryWithoutTaxes
printfn "Salaries with taxes: %A" salariesAfterTax
let adjustedSalaries = salaries |> List.map (fun salary -> if salary <= 49020 then salary + 20000 else salary)
printfn "Salaries Between $49020 with $20000 added to them %A" adjustedSalaries
let sumOfSalaries = 
    salaries 
    |> List.filter (fun salary -> salary >= 50000 && salary <= 100000) 
    |> List.reduce (+) 0
printfn "Sum of salaries between $50,000 and $100,000: %d" sumOfSalaries

//Question2
let rec sum n acc =
    if n = 0 then acc
    else sum (n - 3) (acc + n)
let calculateSum n =
    sum n 0
// Example output
let result = calculateSum 27
printfn "Sum of Multiples of 3 upto 27: %d" result
