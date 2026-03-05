open System

// Задание 1
let readFloats count =
    [ for index in 1 .. count do
        printf "Введите вещественное число %d: " index
        let input = Console.ReadLine()
        yield float input]

[<EntryPoint>]
let main args =
    printf "Введите количество значений списка: "
    let count = Console.ReadLine() |> int

    if count <= 0 then
        printf "Ошибка: количество должно быть положительным!"
        exit 1
    else
        let originalFloats = readFloats count
        let integers = List.map int originalFloats

        printfn "Список тип float: %A" originalFloats
        printfn "Список тип integer: %A" integers
    0