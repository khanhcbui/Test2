Imports System.IO
Imports HtmlAgilityPack

Public Class Html
   Private Sub Parse_Click(sender As Object, e As EventArgs) Handles Parse.Click

      Dim strFileName As String = ""
      'passing strFileName as reference to get the newly unique name for ID while loading the content
      Dim objHTMLRootNode As HtmlNode = LoadHTMLContent(strFileName)

      If objHTMLRootNode IsNot Nothing Then
         'call func to calculate the scores
         Dim intScore = CalculateScore(objHTMLRootNode)

         StoreData(strFileName, intScore)
      End If


   End Sub

   ''' <summary>
   ''' Storing data into DataSet
   ''' </summary>
   ''' <param name="strFileName"></param>
   ''' <param name="intScore"></param>
   ''' <returns></returns>
   Private Sub StoreData(strFileName As String, intScore As Integer)
      'init the adapter to connect
      'get data table
      Dim objDataTable As New DataSet1.HtmlContentDataTable
      'create data row
      Dim objNewRow As DataSet1.HtmlContentRow = objDataTable.NewHtmlContentRow()

      'set data
      objNewRow.ID = strFileName
      objNewRow.RunDateTime = Now

      'add the row to data table
      objDataTable.Rows.Add(objNewRow)

   End Sub

   ''' <summary>
   ''' Calculating the score based on rules.
   ''' </summary>
   ''' <param name="objHTMLRootNode"></param>
   ''' <returns></returns>
   Private Function CalculateScore(objHTMLRootNode As HtmlNode) As Integer
      Dim intScore As Integer = 0

      'get div count
      Dim intDivCount = objHTMLRootNode.Descendants("div").Count
      'get p count
      Dim intPCount = objHTMLRootNode.Descendants("p").Count
      'get h1 count
      Dim intH1Count = objHTMLRootNode.Descendants("h1").Count
      'get h2 count
      Dim intH2Count = objHTMLRootNode.Descendants("h2").Count
      'get hmtl count
      Dim intHtmlCount = objHTMLRootNode.Descendants("hmtl").Count
      'get body count
      Dim intBodyCount = objHTMLRootNode.Descendants("body").Count
      'get header count
      Dim intHeaderCount = objHTMLRootNode.Descendants("header").Count
      'get footer count
      Dim intFooterCount = objHTMLRootNode.Descendants("footer").Count
      'get font count
      Dim intFontCount = objHTMLRootNode.Descendants("font").Count
      'get center count
      Dim intCenterCount = objHTMLRootNode.Descendants("center").Count
      'get big count
      Dim intBigCount = objHTMLRootNode.Descendants("big").Count
      'get strike count
      Dim intStrikeCount = objHTMLRootNode.Descendants("strike").Count
      'get tt count
      Dim intTTCount = objHTMLRootNode.Descendants("tt").Count
      'get frameset count
      Dim intFramesetCount = objHTMLRootNode.Descendants("frameset").Count
      'get frame count
      Dim intFrameCount = objHTMLRootNode.Descendants("frame").Count

      'calculating the score
      intScore = (intDivCount * 3) + (intPCount * 1)



      Return intScore
   End Function

   ''' <summary>
   ''' Load HTML Content from and Return HTML Root Node
   ''' </summary>
   ''' <returns></returns>
   Private Function LoadHTMLContent(ByRef strFileName As String) As HtmlNode
      Dim objHTMLRootNode As HtmlNode = Nothing

      Try
         'get the html content directory
         Dim strHtmlContent As String = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\..\")) + "Data\"
         'get 1st file from the directory
         Dim objFileInfo As FileInfo = New DirectoryInfo(strHtmlContent).GetFiles()(0)

         'create an object to read html
         Dim objHTML As New HtmlDocument
         'load
         objHTML.Load(objFileInfo.FullName)
         'randomly generate id using file name prefix with randomly generated number from 0 to 100
         strFileName = objFileInfo.Name.Replace(objFileInfo.Extension, "") + "_" + New Random().Next(0, 100).ToString

         'get root of the html document node
         objHTMLRootNode = objHTML.DocumentNode

      Catch ex As Exception

      End Try

      Return objHTMLRootNode
   End Function
End Class
