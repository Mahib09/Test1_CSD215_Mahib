let salaries = [75000; 48000; 120000; 190000; 300113; 92000; 36000]
printfn "Base Salaries without Taxes: %A" salaries
let highIncomeSalaries = salaries |> List.filter (fun salary -> salary > 100000)
printfn "High-income salaries: %A" highIncomeSalaries
let calculateTax salary =
    match salary with
    | s when s <= 49020 -> int (float salary * 0.15) 
    | s when s <= 98040 -> int (float salary * 0.205)
    | s when s <= 151978 -> int (float salary * 0.26)
    | s when s <= 216511 -> int (float salary * 0.29)
    | _ -> int (float salary * 0.33)
let taxes = salaries |> List.map calculateTax
printfn "Taxes for all salaries: %A" taxes
let salariesAfterTax = List.map2 (+) salaries taxes
printfn "Salaries with taxes: %A" salariesAfterTax
let adjustedSalaries = salaries |> List.map (fun salary -> if salary <= 49020 then salary + 20000 else salary)
printfn "Adjusted salaries: %A" adjustedSalaries

