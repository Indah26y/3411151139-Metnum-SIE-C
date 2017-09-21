Module Module1

    Sub Main()
        Dim A As Integer
        Dim B As Integer
        Dim hasil As Double

        Console.WriteLine("")
        Console.WriteLine("=================================")
        Console.WriteLine(" METODE NUMERIK ")
        Console.WriteLine("Nama : Indah Putriani Fajar Sidik")
        Console.WriteLine("Nim  : 3411151139")
        Console.WriteLine("Kelas: SIE C")
        Console.WriteLine("=================================")

        For i = 0 To 10
            Console.WriteLine("")
            Console.WriteLine("Tampilkan Menu")
            Console.WriteLine("")
            Console.WriteLine("1.A + B")
            Console.WriteLine("2.A - B")
            Console.WriteLine("3.A / B")
            Console.WriteLine("4.A ^ B")
            Console.WriteLine("5.Deret F(X)=2A^2-4A+1")
            Console.WriteLine("7. KELUAR")
            Console.WriteLine("")
            hasil = Console.ReadLine()
            Console.WriteLine("")

            Console.Write("Masukan nilai A:")
            A = Console.ReadLine()
            Console.Write("Masukan nilai B:")
            B = Console.ReadLine()

            Select Case hasil
                Case 1
                    hasil = A + B
                    Console.WriteLine("Hasil :" & hasil)
                Case 2
                    hasil = A - B
                    Console.WriteLine("Hasil :" & hasil)
                Case 3
                    hasil = A / B
                    Console.WriteLine("Hasil :" & hasil)
                Case 4
                    hasil = A ^ B
                    Console.WriteLine("Hasil :" & hasil)
                Case 5
                    Console.Write("Masukan Nilai A:")
                    A = Console.ReadLine()
                    Console.Write("Masukan Nilai B:")
                    B = Console.ReadLine()
                Case 6
                    End
                    Console.WriteLine("")
            End Select

        Next
    End Sub

End Module
