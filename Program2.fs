open System
//Задание 2
let readStrings count =
    [ for index in 1 .. count do
        printf "Введите элемент %d: " index
        yield Console.ReadLine() ]

[<EntryPoint>]
let main args =
    printf "Введите количество элементов: "
    let count = Console.ReadLine() |> int

    if count <= 0 then
        printfn "Ошибка: количество должно быть положительным!"
        exit 1
    else
        let strings = readStrings count
        
        let evenCount = 
            List.fold (fun (acc: int) (s: string) -> 
                if s.Length % 2 = 0 then 
                    acc + 1 
                else 
                    acc
            ) 0 strings
        
        printfn "Список строк: %A" strings
        printfn "Строк с чётной длиной: %d" evenCount
        0
