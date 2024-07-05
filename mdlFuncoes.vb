Imports System.IO
Imports System.Threading.Thread
Imports System.Globalization
Module mdlFuncoes
    'Public meuServidor As String = "SJFPA008\DEV"
    Public total2
    Dim tbaux3, tabela, tbcaixa, rs, tbconfig, tbaux, tbpermissao, tbClientes

    Declare Function GetUserName Lib "advapi32.dll" Alias _
"GetUserNameA" (ByVal lpBuffer As String, _
ByRef nSize As Integer) As Integer

    Declare Function GetComputerName Lib "kernel32" Alias _
"GetComputerNameA" (ByVal lpBuffer As String, _
ByRef nSize As Integer) As Integer
    Public Function GetUserName() As String
        Dim iReturn As Integer
        Dim userName As String

        userName = New String(CChar(" "), 50)
        iReturn = GetUserName(userName, 50)
        GetUserName = userName.Substring(0, userName.IndexOf(Chr(0)))
        'Retorna o nome do usuário do windows
    End Function
    Public Function GetComputerName() As String
        Dim iReturn As Integer
        Dim computerName As String

        computerName = New String(CChar(" "), 30)
        iReturn = GetComputerName(computerName, 30)
        GetComputerName = computerName.Substring(0, computerName.IndexOf(Chr(0)))
        'Retorna o nome do computador
    End Function

    Public Function mcripto(ByVal wvTEXTO As String)
        Dim wvTEXTO1, wvTEXTO2, wvRETORNA As String
        Dim X, Y, INDICE As Integer
        Dim CARACTER As String
        wvTEXTO = UCase(wvTEXTO)
        wvRETORNA = ""
        wvTEXTO1 = "ABCDEFGHIJKLMNOPQRSTUVXYZ1234567890 WÇÃÕ"
        wvTEXTO2 = "!@#$%^&*()_+|=\-][{}?/><,.~`®¬½¼¡«»¨©ÇÕÃ"
        For X = 1 To Len(wvTEXTO)
            CARACTER = Right(Left(wvTEXTO, X), 1)
            For Y = 1 To Len(wvTEXTO1)

                If CARACTER = Right(Left(wvTEXTO1, Y), 1) Then
                    INDICE = Y

                End If
            Next
            wvRETORNA = wvRETORNA + Right(Left(wvTEXTO2, INDICE), 1)

        Next

        mcripto = wvRETORNA

    End Function
    Public Function muncripto(ByVal wvTEXTO As String)
        Dim X, Y, INDICE As Integer
        Dim CARACTER As String
        Dim wvTEXTO1, wvTEXTO2, wvRETORNA As String
        wvRETORNA = ""
        wvTEXTO = UCase(wvTEXTO)
        wvTEXTO2 = "ABCDEFGHIJKLMNOPQRSTUVXYZ1234567890 WÇÃÕ"
        wvTEXTO1 = "!@#$%^&*()_+|=\-][{}?/><,.~`®¬½¼¡«»¨©ÇÕÃ"
        For X = 1 To Len(wvTEXTO)
            CARACTER = Right(Left(wvTEXTO, X), 1)
            For Y = 1 To Len(wvTEXTO1)

                If CARACTER = Right(Left(wvTEXTO1, Y), 1) Then
                    INDICE = Y

                End If
            Next
            wvRETORNA = wvRETORNA + Right(Left(wvTEXTO2, INDICE), 1)

        Next

        muncripto = wvRETORNA

    End Function
    Public Function carregalista(ByVal lista As CheckedListBox, ByVal sql As String, ByVal campo As String, Optional ByVal checa As Boolean = False) As Boolean
        Dim tbLista As DataTable
        tbLista = RecebeTabela(sql)

        If tbLista.Rows.Count = 0 Then
            Return False
        End If

        For Each row As DataRow In tbLista.Rows
            lista.Items.Add(row(campo).ToString())
        Next

        Return True
    End Function


    Public Function ProcessFile(ByVal cxTexto As ListBox, ByVal strFile As String)
        'DECLARA UM OBJETO PARA A CLASSE STREAMREADER

        cxTexto.Items.AddRange(File.ReadAllLines(strFile))
        'Dim linhas() As String
        ''ABRE O ARQUIVO
        'linhas = File.ReadAllLines(strFile)
        'cxTexto.Items.AddRange(linhas)
        '        cxTexto.Refresh()
        ProcessFile = True
    End Function
    Public Function encontrachr(ByVal texto As String, ByVal caract As String, ByVal posicao As Integer) As String
        Dim y As Integer
        Dim posicoes As Integer
        Dim ultima As Integer
        Dim achou As Boolean
        Dim retorno As String
        posicoes = 1
        ultima = 0
        achou = False
        retorno = ""
        For y = 1 To Len(texto)

            If Mid(texto, y, 1) = caract Then
                If posicoes = posicao Then
                    retorno = Mid(texto, IIf(ultima = 0, 1, ultima), IIf(ultima = 0, y - ultima - 1, y - ultima))
                    achou = True
                    Exit For
                Else
                    achou = False
                End If
                posicoes = posicoes + 1
                ultima = y + 1
            End If
        Next
        If achou = False Then
            retorno = Mid(texto, IIf(ultima = 0, 1, ultima), IIf(ultima = 0, y - ultima - 1, y - ultima))
        End If
        encontrachr = retorno
    End Function
    Public Function montadata(ByVal data As String) As Date
        Dim novadata As String
        novadata = Left(data, 2) & "/" & Mid(data, 3, 2) & "/" & Right(data, 4)
        If IsDate(novadata) = False Then
            montadata = Date.Today
            Exit Function
        End If
        montadata = CDate(novadata)

    End Function
    Public Function montargrade(ByVal sql As String, ByVal grade As DataGridView, ByVal textodestino As TextBox, ByVal ParamArray conteudo() As Object) As Boolean
        Dim x As Integer, y As Integer, total As Long

        tabela = RecebeTabela(sql)
        total = 0
        grade.Rows.Clear()
        If tabela.RecordCount <> 0 Then
            tabela.MoveFirst()

            x = 0
            While tabela.EOF = False
                grade.Rows.Add(tabela.Fields(conteudo(0)).Value.ToString)
                For y = 1 To UBound(conteudo)
                    grade.Item(y, x).Value = tabela.Fields(conteudo(y)).Value.ToString
                Next
                x = x + 1
                total = total + 1
                tabela.MoveNext()
            End While
            montargrade = True
        Else

            montargrade = False
        End If
        textodestino.Text = total
    End Function

    Public Function centraliza(ByVal frase As String, ByVal valor As Integer)
        Return (valor - frase.Length) / 2
    End Function

    Public Function moeda(ByVal valor As String)
        If valor = "" Then
            moeda = 0
            Exit Function
        End If
        Dim novovalor As String = valor.Replace("R$", "").Replace(".", "")
        Return novovalor.Replace(",", ".").Trim
    End Function
    Public Function definesemestre(ByVal data As Date) As Integer
        If data.Month < 7 Then
            Return 1
        Else
            Return 2
        End If
    End Function
    Public Function diasuteis(ByVal mes As Integer, ByVal ano As Integer, ByVal diautil As Integer) As Date
        Dim data, novadata As Date
        Dim x, dias As Integer
        data = CDate("01/" & mes & "/" & ano)
        x = 0
        dias = 0
        While dias < diautil
            novadata = data.AddDays(x)
            If novadata.DayOfWeek = DayOfWeek.Saturday Or novadata.DayOfWeek = DayOfWeek.Sunday Then
            Else
                dias += 1
            End If
            x += 1
        End While
        Return novadata
    End Function
    Public Function zeros(ByVal expr As String, ByVal qtd As Integer)
        Dim dd As String
        Dim x As Integer
        dd = ""
        If qtd <= Len(expr) Then
            Return expr
            Exit Function
        End If
        For x = 1 To (qtd - Len(expr))
            dd = dd & "0"
        Next
        Return dd & expr

    End Function

    Public Function tratadata(ByVal data As String, Optional ByVal mascara As String = "dd/MM/yyyy") As Date
        If IsDate(data) Then
            Return Format(CDate(data), mascara)
        Else
            data = "01/01/1900"
            Return Format(CDate(data), mascara)
        End If

    End Function
    Public Function tratadata2(ByVal data As String) As Date
        'Dim novadata As String
        ' novadata = data.Substring(0, 2) & "/" & data.Substring(2, 2) & "/" & data.Substring(4, 4)
        'If IsDate(novadata) = True Then
        'Return Format(CDate(novadata), "dd/MM/yyyy")
        ' Else
        ' Return Format(CDate("01/01/1900"), "dd/MM/yyyy")
        ' End If
    End Function


    'Public Function VAL_CPF(ByVal CPF As String) As Boolean

    '    'TRUE = INVÁLIDO ... FALSE = VÁLIDO

    '    Dim CONT, I As Byte
    '    Dim CPFa(11), CPFb(11), SM As Integer

    '    CPF = Replace(CPF, ".", vbNullString)
    '    CPF = Replace(CPF, "-", vbNullString)

    '    If Len(CPF) <> 11 Then
    '        VAL_CPF = False
    '    Else

    '        ''''''VERIFICA CARACTERES INVÁLIDOS''''''
    '        If Not IsNumeric(CPF) Then
    '            VAL_CPF = True
    '        Else

    '            ''''''VERIFICA NUMERAÇÃO''''''
    '            If CPF = "11111111111" Or CPF = "22222222222" Or _
    '                CPF = "33333333333" Or CPF = "44444444444" Or _
    '                CPF = "55555555555" Or CPF = "66666666666" Or _
    '                CPF = "77777777777" Or CPF = "88888888888" Or _
    '                CPF = "99999999999" Or CPF = "00000000000" Then

    '                VAL_CPF = True

    '            Else
    '                ''''''CARREGA VETOR''''''
    '                For I = 1 To 11

    '                    CPFa(I) = Mid(CPF, I, 1)

    '                Next I
    '                ''''''FIM CARREGA VETOR''''''

    '                ''''''1° DIGITO''''''
    '                CONT = 10
    '                SM = 0

    '                For I = 1 To 9

    '                    CPFb(I) = CPFa(I) * CONT

    '                    CONT = CONT - 1

    '                    SM = SM + CPFb(I)

    '                Next I

    '                If SM Mod 11 < 2 Then

    '                    CPFa(10) = 0

    '                Else

    '                    CPFa(10) = 11 - (SM Mod 11)

    '                End If
    '                ''''''FIM 1° DIGITO''''''

    '                ''''''2° DIGITO''''''
    '                CONT = 11
    '                SM = 0

    '                For I = 1 To 10

    '                    CPFb(I) = CPFa(I) * CONT
    '                    CONT = CONT - 1
    '                    SM = SM + CPFb(I)

    '                Next I

    '                If SM Mod 11 < 2 Then
    '                    CPFa(11) = 0
    '                Else
    '                    CPFa(11) = 11 - (SM Mod 11)
    '                End If
    '                ''''''FIM 2° DIGITO''''''

    '                ''''''VERIFICA OS DIGITOS''''''
    '                If Mid(CPF, 10, 2) <> CPFa(10) & CPFa(11) Then
    '                    VAL_CPF = True
    '                End If
    '                ''''''FIM VERIFICA OS DIGITOS''''''

    '            End If
    '            ''''''FIM VERIFICA NUMERAÇÃO''''''

    '        End If
    '        ''''''FIM VERIFICA CARACTERES INVÁLIDOS''''''

    '    End If

    'End Function

    Public Function VAL_CPF(ByVal CPF As String) As Boolean
        On Error Resume Next
        Dim soma As Integer
        Dim Resto As Integer
        Dim i As Integer
        'Valida argumento
1:      CPF = Replace(CPF, ".", "")
2:      CPF = Replace(CPF, "-", "")
3:      If Len(CPF) <> 11 Then
4:          Return False
            Exit Function
        End If
5:      soma = 0
        For i = 1 To 9
6:          soma = soma + Val(Mid$(CPF, i, 1)) * (11 - i)
7:      Next i
8:      Resto = 11 - (soma - (Int(soma / 11) * 11))
9:      If Resto = 10 Or Resto = 11 Then Resto = 0
10:     If Resto <> Val(Mid$(CPF, 10, 1)) Then
11:         Return False
            Exit Function
        End If
12:     soma = 0
        For i = 1 To 10
13:         soma = soma + Val(Mid$(CPF, i, 1)) * (12 - i)
14:     Next i
15:     Resto = 11 - (soma - (Int(soma / 11) * 11))
16:     If Resto = 10 Or Resto = 11 Then Resto = 0
17:     If Resto <> Val(Mid$(CPF, 11, 1)) Then
18:         Return False
            Exit Function
        End If
19:     Return True
    End Function
    Public Function completa(ByVal mensagem As String, ByVal espacos As Integer, Optional ByVal alinha As String = "e", Optional ByVal formato As String = "")

        mensagem = Trim(mensagem)
        If formato <> "" Then

            If Format(formato, "<") = "n" Then
                mensagem = Format(mensagem, "###,###,##0.00")
            Else
                If Format(formato, "<") = "data" Then
                    mensagem = Format(mensagem, "dd/mm/yyyy")
                    '            If Format(formato, "<") = "currency" Then
                    '                mensagem = "R$" & CStr(Format(mensagem, "###,###,##0.00"))
                Else
                    mensagem = Format(mensagem.Trim, formato)
                    '            End If
                End If
            End If
        End If

        If Len(Trim(mensagem)) > espacos Then
            'espacos = Len(RTrim(mensagem))
            Return Left(mensagem.Trim, espacos)
            Exit Function
        End If

        If Format(alinha, "<") = "d" Then
            Return Space(espacos - Len((mensagem.Trim))) + mensagem.Trim
        Else
            Return mensagem.Trim + Space(espacos - Len((mensagem.Trim)))
        End If

    End Function


    Public Function conectado() As Boolean
        Try
            Return My.Computer.Network.Ping("www.globo.com")
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Function validarserial(Optional ByVal operacao As String = "VALIDAR") As Boolean
        Dim arquivo As String
        If operacao.ToUpper = "VALIDAR" Then
            Try

                arquivo = "c:\temp\" & serialhd("c:\") & ".txt"
                If My.Computer.FileSystem.DirectoryExists("c:\temp") = False Then
                    My.Computer.FileSystem.CreateDirectory("c:\temp")
                End If
                If My.Computer.FileSystem.FileExists(arquivo) = True Then
                    My.Computer.FileSystem.DeleteFile(arquivo)
                End If
                My.Computer.Network.DownloadFile("http://br.geocities.com/caafs2/" & serialhd("c:\") & ".txt", arquivo)
                validarserial = True
            Catch ex As Exception
                validarserial = False
            End Try
            Exit Function
        Else
            arquivo = "c:\temp\" & serialhd("c:\") & ".txt"
            If My.Computer.FileSystem.DirectoryExists("c:\temp") = False Then
                My.Computer.FileSystem.CreateDirectory("c:\temp")
            End If
            If My.Computer.FileSystem.FileExists(arquivo) = True Then
                My.Computer.FileSystem.DeleteFile(arquivo)
            End If
            Dim arq As StreamWriter = New StreamWriter(arquivo)
            arq.WriteLine(arquivo)
            arq.Close()
            'My.Computer.Network.UploadFile(arquivo, "http://br.geocities.com/caafs2", "caafs2", "a1b1c1d1")
            My.Computer.Network.UploadFile(arquivo, "https://cp1.runhosting.com/ftp_manager.html", "204774", "208bfcae")
        End If
    End Function
    Public Function serialhd(ByVal driveletter As String)

        Dim fso As Object
        Dim Drv As Object
        Dim DriveSerial As String
        'Cria um objeto FileSystemObject
        fso = CreateObject("Scripting.FileSystemObject")

        'Atribui a letra do drive atual se nada for especificado
        If driveletter <> "" Then
            Drv = fso.GetDrive(driveletter)
        Else
            Drv = fso.GetDrive(fso.GetDriveName("c:\"))
        End If

        With Drv
            If .IsReady Then
                DriveSerial = Int(.SerialNumber)
            Else '"Drive não esta pronto!"
                DriveSerial = -1
            End If
        End With

        'libera objetos
        Drv = Nothing
        fso = Nothing

        serialhd = DriveSerial

    End Function
    Public Function primeiraletra(ByVal palavra As String)
        If palavra.Length = 0 Then
            Return ""
            Exit Function
        End If
        Dim x As Integer
        Dim nova As String
        nova = ""
        nova = palavra.Substring(0, 1).ToUpper

        For x = 1 To palavra.Length - 1
            If palavra.Substring(x - 1, 1).ToUpper = " " Then
                nova = nova & palavra.Substring(x, 1).ToUpper
            Else
                nova = nova & palavra.Substring(x, 1).ToLower
            End If
        Next
        Return nova
    End Function
    Public Function mPASTA(ByVal wcCAMINHO As String)
        Dim wctemp
        Dim xx As Integer
        For xx = 1 To Len(wcCAMINHO)
            If Left(Right(wcCAMINHO, xx + 1), 1) = "\" Then
                wctemp = Len(Right(wcCAMINHO, xx))
                mPASTA = Left(wcCAMINHO, Len(wcCAMINHO) - wctemp)
                xx = Len(wcCAMINHO)
            End If
        Next
        Return ""
    End Function
    Public Function UltimoDia(ByVal wcdata As Date) As Date
        wcdata = wcdata.AddMonths(1)
        wcdata = wcdata.AddDays(-1)
        Return wcdata
    End Function
    Public Function CtrlMenu(ByVal permissao As String, Optional ByVal esconder As Boolean = False) As Boolean
        For Each item As ToolStripItem In frmPrincipal.MenuStrip1.Items
            If TypeOf item Is ToolStripMenuItem Then
                Dim menu As ToolStripMenuItem = DirectCast(item, ToolStripMenuItem)
                Dim sql As String = $"Select * from tbpermissoes where permissao = '{permissao}' and menu = '{menu.Text}'"
                tbpermissao = RecebeTabela(sql)

                If tbpermissao.Rows.Count > 0 Then
                    If Convert.ToBoolean(tbpermissao.Rows(0)("ativo")) Then
                        If Not esconder Then
                            menu.Enabled = True
                        Else
                            menu.Visible = True
                        End If
                    Else
                        If Not esconder Then
                            menu.Enabled = False
                        Else
                            menu.Visible = False
                        End If
                    End If
                Else
                    If Not esconder Then
                        menu.Enabled = True
                    Else
                        menu.Visible = True
                    End If
                End If

                ctrlmenusubmenu(menu, permissao, esconder)
            End If
        Next

        Return True
    End Function
    Public Function ctrlmenusubmenu(ByVal menu As ToolStripMenuItem, ByVal permissao As String, Optional ByVal esconder As Boolean = False) As Boolean
        For Each item As ToolStripItem In menu.DropDownItems
            If TypeOf item Is ToolStripMenuItem Then
                Dim submenu As ToolStripMenuItem = DirectCast(item, ToolStripMenuItem)
                Dim sql As String = $"Select * from tbpermissoes where permissao = '{permissao}' and menu = '{submenu.Text}'"
                tbpermissao = RecebeTabela(sql)

                If tbpermissao.Rows.Count > 0 Then
                    If Convert.ToBoolean(tbpermissao.Rows(0)("ativo")) Then
                        If Not esconder Then
                            submenu.Enabled = True
                        Else
                            submenu.Visible = True
                        End If
                    Else
                        If Not esconder Then
                            submenu.Enabled = False
                        Else
                            submenu.Visible = False
                        End If
                    End If
                Else
                    If Not esconder Then
                        submenu.Enabled = True
                    Else
                        submenu.Visible = True
                    End If
                End If

                ctrlmenusubmenu(submenu, permissao, esconder)
            End If
        Next

        Return True
    End Function

    Public Function achanumerodependente(ByVal matricula As String, ByVal nome As String) As Integer
        Dim sql As String = $"Select nrseq from tbdependentes where matricula = '{matricula}' order by nrseq"
        tbaux3 = RecebeTabela(sql)

        Dim x As Integer = 1

        For Each row As DataRow In tbaux3.Rows
            If nome.ToUpper().Trim() = row("nome").ToString().ToUpper().Trim() Then
                Return x
            End If
            x += 1
        Next

        Return 0
    End Function
    Public Function administrador(ByVal nome As String) As Boolean
        Dim sql As String = $"Select * from vwUsuariosAdministradores where nome = '{nome}'"
        tbaux = RecebeTabela(sql)

        Return tbaux.Rows.Count > 0
    End Function
    Public Function caixaaberto(ByVal funcionario As String) As Integer
        If Not existecaixa() Then
            Return 0
        End If

        Dim sql As String = $"Select nrseqcaixa from tbcaixa where funcionario = '{funcionario}' and not fechado order by nrseqcaixa desc"
        tbcaixa = RecebeTabela(sql)

        If tbcaixa.Rows.Count > 0 Then
            Return Convert.ToInt32(tbcaixa.Rows(0)("nrseqcaixa"))
        Else
            Return -1
        End If
    End Function
    Public Function existecaixa() As Boolean
        tbconfig = RecebeTabela("select * from tbconfig")

        If tbconfig.Rows.Count > 0 AndAlso Not IsDBNull(tbconfig.Rows(0)("temporario")) Then
            Return File.Exists(tbconfig.Rows(0)("temporario").ToString())
        End If

        Return False
    End Function
    Public Function meucaixa(ByVal nrcaixa As Integer) As Decimal
        Dim sql As String
        Dim wcvalor As Decimal = 0

        sql = $"Select valorinicial from tbcaixa where nrseqcaixa = {nrcaixa}"
        tbcaixa = RecebeTabela(sql)

        If tbcaixa.Rows.Count > 0 AndAlso Not IsDBNull(tbcaixa.Rows(0)("valorinicial")) Then
            wcvalor = Convert.ToDecimal(tbcaixa.Rows(0)("valorinicial"))
        End If

        sql = $"Select valor from tbcaixadth where nrseqcaixa = {nrcaixa}"
        tbcaixa = RecebeTabela(sql)

        For Each row As DataRow In tbcaixa.Rows
            wcvalor += Convert.ToDecimal(row("valor"))
        Next

        Return wcvalor
    End Function

    Public Function ContarRegistros() As String
        Dim tbClientes As DataTable
        Dim temp As Integer
        Dim mov As String

        tbClientes = RecebeTabela("select count(*) as total_clientes from tbClientes")
        If tbClientes.Rows.Count > 0 AndAlso Not IsDBNull(tbClientes.Rows(0)("total_clientes")) Then
            temp = Convert.ToInt32(tbClientes.Rows(0)("total_clientes"))
        Else
            temp = 0
        End If

        If temp = 1 Then
            mov = temp & " Cliente Cadastrado"
        Else
            mov = temp & " Clientes Cadastrados"
        End If

        frmClientes.lblRegistro.Text = mov
        Return mov
    End Function
    Public Function pegamenus(ByVal listbox1 As CheckedListBox, ByVal menustrip1 As MenuStrip)
        Dim x, y, z As Integer
        Dim v As System.Windows.Forms.ToolStripMenuItem
        Dim submenu As System.Windows.Forms.ToolStripMenuItem

        listbox1.Items.Clear()
        For x = 0 To menustrip1.Items.Count - 1
            v = menustrip1.Items(x)
            If v.Text <> "" Then
                listbox1.Items.Add(v.Text)

                For y = 0 To v.DropDown.Items.Count - 1
                    If v.DropDown.Items(y).Text <> "" Then
                        listbox1.Items.Add(v.DropDown.Items(y).Text)
                        If v.DropDown.Items(y).Text <> "" Then
                            submenu = v.DropDown.Items(y)
                            If submenu.DropDownItems.Count <> 0 Then
                                For z = 0 To submenu.DropDownItems.Count - 1
                                    If submenu.DropDownItems.Item(z).Text <> "" Then
                                        listbox1.Items.Add(submenu.DropDown.Items(z).Text)
                                    End If
                                Next
                            End If
                        End If
                    End If
                Next
            End If
        Next
        pegamenus = ""
    End Function
    'Function GeraCodigo() As String
    '    Dim Soma = frmCaderneta.Label2.Text
    '    Dim Anotar As Integer
    '    Dim Numero As String
    '    Try
    '        Anotar = CInt(Soma.Substring(Soma.IndexOf("-") + 1, Soma.Length - Soma.IndexOf("-")) + 1
    '        Numero = Anotar.ToString()
    '        Return string(4 - Numero.Length,"0") + Trim(Numero)
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "error")
    '    End Try
    'End Function
    Public Function GeraCodigo()

        Dim Soma = frmCaderneta.Label2.Text
        Dim Anotar As Integer
        Dim NovoSlip As String = "000"
        Dim Numero As String

        Try
            Anotar = CInt(Soma.TrimStart("U", "s", "e", "r", "-"))
            Anotar += 1
            Numero = Anotar.ToString()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "error")
        End Try

        Return NovoSlip + Numero
    End Function
    'Public Function ExportarExcel(ByVal L As Object)
    '    Dim oExcl As Object
    '    Dim oWrkb As Object
    '    Dim oWrks As Object
    '    Dim oChrt As Object
    '    Dim Linha As Integer
    '    Dim Coluna As Integer

    '    oExcl = CreateObject(Excel.Application)
    '    oWrks = CreateObject(Excel.Sheet)
    '    oChrt = CreateObject(Excel.Chart)

    '    oWrkb = oExcl.Workbooks.Add
    '    oWrks = oWrkb.Worksheets(1)

    '    oWrks.Rows(1).Font.Bold = True
    '    For Coluna = 1 To L.Columns.Count
    '        oWrks.Rows(1).Cells(, Coluna).Value = L.Columns(Coluna).Text
    '    Next Coluna

    '    For Linha = 1 To L.ListItems.Count
    '        oWrks.Cells(Linha + 1, 1).Value = L.ListItems(Linha).Text
    '        For Coluna = 2 To L.Columns.Count
    '            oWrks.Cells(Linha + 1, Coluna).Value = L.ListItems(Linha).SubItems(Coluna - 1)
    '        Next Coluna
    '    Next Linha

    '    oExcl.Visible = True
    '    oExcl.UserControl = True

    '    oExcl = Nothing
    '    oWrks = Nothing
    '    oChrt = Nothing
    'End Function

End Module
