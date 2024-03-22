// List of salaries
let salaries = [75000; 48000; 120000; 190000; 300113; 92000; 36000]
// Filter high-income salaries (above $100,000)
let highIncomeSalaries = salaries |> List.filter (fun salary -> salary > 100000)
printfn "High-income salaries: %A" highIncomeSalaries
// Federal income tax calculation function
let calculateTax salary =
    match salary with
    | s when s <= 49020 -> int (float salary * 0.15) // 15% tax for salaries of 49020 or less
    | s when s <= 98040 -> int (float salary * 0.205) // 20.5% tax for salaries between $49,020 and $98,040
    | s when s <= 151978 -> int (float salary * 0.26) // 26% tax for salaries between $98,041 and $151,978
    | s when s <= 216511 -> int (float salary * 0.29) // 29% tax for salaries between $151,979 and $216,511
    | _ -> int (float salary * 0.33) // 33% tax for salaries above $216,511
// Map function to calculate tax for all salaries
let taxes = salaries |> List.map calculateTax
printfn "Taxes for all salaries: %A" taxes
// Calculate salaries after tax
let salariesAfterTax = List.map2 (+) salaries taxes
printfn "Salaries with taxes: %A" salariesAfterTax
// Filter salaries less than $49,020 and add $20,000 to these salaries
let adjustedSalaries = salaries |> List.map (fun salary -> if salary <= 49020 then salary + 20000 else salary)
printfn "Adjusted salaries: %A" adjustedSalaries
// Filter salaries between $50,000 and $100,000 and sum them all using the fold function
let sumSalaries = 
    salaries 
    |> List.filter (fun salary -> salary >= 50000 && salary <= 100000) 
    |> List.fold (+) 0
printfn "Sum of salaries between $50,000 and $100,000: %d" sumSalaries
