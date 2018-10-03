Public Class Form1

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

        Dim random As New Random()

        'copper rolls
        Dim copper1 As Integer = random.Next(1, 100)
        Dim copper2 As Integer = random.Next(1, 100)
        Dim copper3 As Integer = random.Next(1, 100)
        Dim copper4 As Integer = random.Next(1, 100)
        Dim copper5 As Integer = random.Next(1, 100)
        Dim copper6 As Integer = random.Next(1, 100)
        Dim copper7 As Integer = random.Next(1, 100)
        Dim copper8 As Integer = random.Next(1, 100)
        Dim copper9 As Integer = random.Next(1, 100)

        CopperA.Clear()
        CopperB.Clear()
        CopperC.Clear()
        CopperD.Clear()
        CopperE.Clear()
        CopperF.Clear()
        CopperH.Clear()
        CopperI.Clear()


        If copper1 <= 25 Then
            Dim coppercoin1 As Integer = random.Next(1, 3) * 1000
            CopperA.Text = coppercoin1
        End If
        If copper2 <= 50 Then
            Dim coppercoin2 As Integer = random.Next(1, 6) * 1000
            CopperB.Text = coppercoin2
        End If
        If copper3 <= 20 Then
            Dim coppercoin3 As Integer = random.Next(1, 10) * 1000
            CopperC.Text = coppercoin3
        End If
        If copper4 <= 10 Then
            Dim coppercoin4 As Integer = random.Next(1, 6) * 1000
            CopperD.Text = coppercoin4
        End If
        If copper5 <= 5 Then
            Dim coppercoin5 As Integer = random.Next(1, 6) * 1000
            CopperE.Text = coppercoin5
        End If
        If copper6 <= 0 Then
            Dim coppercoin5 As Integer = random.Next(1, 6) * 1000
            CopperE.Text = coppercoin5
        End If
        If copper7 <= 0 Then
            Dim coppercoin7 As Integer = random.Next(1, 6) * 1000
            CopperF.Text = coppercoin7
        End If
        If copper8 <= 25 Then
            Dim coppercoin8 As Integer = random.Next(3, 20) * 1000
            CopperH.Text = coppercoin8
        End If
        If copper9 <= 0 Then
            Dim coppercoin9 As Integer = random.Next(1, 6) * 1000
            CopperI.Text = coppercoin9
        End If

        'silver rolls
        Dim silver1, silver2, silver3, silver4, silver5, silver6, silver7, silver8, silver9 As Integer
        silver1 = random.Next(1, 100)
        silver2 = random.Next(1, 100)
        silver3 = random.Next(1, 100)
        silver4 = random.Next(1, 100)
        silver5 = random.Next(1, 100)
        silver6 = random.Next(1, 100)
        silver7 = random.Next(1, 100)
        silver8 = random.Next(1, 100)
        silver9 = random.Next(1, 100)


        For Each txt In {silverA, silverB, silverC, silverD, silverE, silverF, silverG, silverH, silverI}
            txt.Clear()
        Next


        If silver1 <= 30 Then
            Dim silvercoin1 As Integer = random.Next(2, 20) * 100
            silverA.Text = silvercoin1
        End If
        If silver2 <= 25 Then
            Dim silvercoin2 As Integer = random.Next(1, 3) * 1000
            silverB.Text = silvercoin2
        End If
        If silver3 <= 30 Then
            Dim silvercoin3 As Integer = random.Next(1, 6) * 1000
            silverC.Text = silvercoin3
        End If
        If silver4 <= 15 Then
            Dim silvercoin4 As Integer = random.Next(1, 10) * 1000
            silverD.Text = silvercoin4
        End If
        If silver5 <= 25 Then
            Dim silvercoin5 As Integer = random.Next(1, 10) * 1000
            silverE.Text = silvercoin5
        End If
        If silver6 <= 10 Then
            Dim silvercoin5 As Integer = random.Next(3, 18) * 1000
            silverF.Text = silvercoin5
        End If
        If silver7 <= 0 Then
            Dim silvercoin7 As Integer = random.Next(1, 6) * 1000
            silverG.Text = silvercoin7
        End If
        If silver8 <= 40 Then
            Dim silvercoin8 As Integer = random.Next(2, 20) * 1000
            silverH.Text = silvercoin8
        End If
        If silver9 <= 0 Then
            Dim silvercoin9 As Integer = random.Next(1, 6) * 1000
            silverI.Text = silvercoin9
        End If

        'gold rolls
        Dim gold1, gold2, gold3, gold4, gold5, gold6, gold7, gold8, gold9 As Integer
        gold1 = random.Next(1, 100)
        gold2 = random.Next(1, 100)
        gold3 = random.Next(1, 100)
        gold4 = random.Next(1, 100)
        gold5 = random.Next(1, 100)
        gold6 = random.Next(1, 100)
        gold7 = random.Next(1, 100)
        gold8 = random.Next(1, 100)
        gold9 = random.Next(1, 100)


        For Each txt In {goldA, goldB, goldC, goldD, goldE, goldF, goldG, goldH, goldI}
            txt.Clear()
        Next


        If gold1 <= 40 Then
            Dim goldcoin1 As Integer = random.Next(1, 6) * 1000
            goldA.Text = goldcoin1
        End If
        If gold2 <= 25 Then
            Dim goldcoin2 As Integer = random.Next(2, 20) * 100
            goldB.Text = goldcoin2
        End If
        If gold3 <= 0 Then
            Dim goldcoin3 As Integer = random.Next(1, 6) * 1000
            goldC.Text = goldcoin3
        End If
        If gold4 <= 50 Then
            Dim goldcoin4 As Integer = random.Next(1, 3) * 1000
            goldD.Text = goldcoin4
        End If
        If gold5 <= 25 Then
            Dim goldcoin5 As Integer = random.Next(1, 4) * 1000
            goldE.Text = goldcoin5
        End If
        If gold6 <= 40 Then
            Dim goldcoin5 As Integer = random.Next(1, 6) * 1000
            goldF.Text = goldcoin5
        End If
        If gold7 <= 50 Then
            Dim goldcoin7 As Integer = random.Next(2, 20) * 1000
            goldG.Text = goldcoin7
        End If
        If gold8 <= 55 Then
            Dim goldcoin8 As Integer = random.Next(2, 20) * 1000
            goldH.Text = goldcoin8
        End If
        If gold9 <= 0 Then
            Dim goldcoin9 As Integer = random.Next(1, 6) * 1000
            goldI.Text = goldcoin9
        End If

        'plat rolls
        Dim plat1, plat2, plat3, plat4, plat5, plat6, plat7, plat8, plat9 As Integer
        plat1 = random.Next(1, 100)
        plat2 = random.Next(1, 100)
        plat3 = random.Next(1, 100)
        plat4 = random.Next(1, 100)
        plat5 = random.Next(1, 100)
        plat6 = random.Next(1, 100)
        plat7 = random.Next(1, 100)
        plat8 = random.Next(1, 100)
        plat9 = random.Next(1, 100)


        For Each txt In {platA, platB, platC, platD, platE, platF, platG, platH, platI}
            txt.Clear()
        Next


        If plat1 <= 35 Then
            Dim platcoin1 As Integer = random.Next(3, 18) * 100
            platA.Text = platcoin1
        End If
        If plat2 <= 25 Then
            Dim platcoin2 As Integer = random.Next(1, 10) * 100
            platB.Text = platcoin2
        End If
        If plat3 <= 10 Then
            Dim platcoin3 As Integer = random.Next(1, 6) * 100
            platC.Text = platcoin3
        End If
        If plat4 <= 15 Then
            Dim platcoin4 As Integer = random.Next(1, 6) * 100
            platD.Text = platcoin4
        End If
        If plat5 <= 25 Then
            Dim platcoin5 As Integer = random.Next(3, 18) * 100
            platE.Text = platcoin5
        End If
        If plat6 <= 15 Then
            Dim platcoin5 As Integer = random.Next(1, 4) * 1000
            platF.Text = platcoin5
        End If
        If plat7 <= 50 Then
            Dim platcoin7 As Integer = random.Next(1, 10) * 1000
            platG.Text = platcoin7
        End If
        If plat8 <= 40 Then
            Dim platcoin8 As Integer = random.Next(1, 8) * 1000
            platH.Text = platcoin8
        End If
        If plat9 <= 30 Then
            Dim platcoin9 As Integer = random.Next(1, 6) * 100
            platI.Text = platcoin9
        End If

        'gem rolls
        Dim gem1, gem2, gem3, gem4, gem5, gem6, gem7, gem8, gem9 As Integer
        gem1 = random.Next(1, 100)
        gem2 = random.Next(1, 100)
        gem3 = random.Next(1, 100)
        gem4 = random.Next(1, 100)
        gem5 = random.Next(1, 100)
        gem6 = random.Next(1, 100)
        gem7 = random.Next(1, 100)
        gem8 = random.Next(1, 100)
        gem9 = random.Next(1, 100)


        For Each txt In {gemA, gemB, gemC, gemD, gemE, gemF, gemG, gemH, gemI}
            txt.Clear()
        Next


        If gem1 <= 60 Then
            Dim gems1 As Integer = random.Next(1, 4) * 10
            gemA.Text = gems1
        End If
        If gem2 <= 30 Then
            Dim gems2 As Integer = random.Next(1, 8)
            gemB.Text = gems2
        End If
        If gem3 <= 25 Then
            Dim gems3 As Integer = random.Next(1, 6)
            gemC.Text = gem3
        End If
        If gem4 <= 30 Then
            Dim gems4 As Integer = random.Next(1, 10)
            gemD.Text = gems4
        End If
        If gem5 <= 15 Then
            Dim gems5 As Integer = random.Next(1, 12)
            gemE.Text = gems5
        End If
        If gem6 <= 20 Then
            Dim gems5 As Integer = random.Next(2, 20)
            gemF.Text = gems5
        End If
        If gem7 <= 30 Then
            Dim gems7 As Integer = random.Next(3, 18)
            gemG.Text = gems7
        End If
        If gem8 <= 50 Then
            Dim gems8 As Integer = random.Next(3, 30)
            gemH.Text = gems8
        End If
        If gem9 <= 55 Then
            Dim gems9 As Integer = random.Next(2, 12)
            gemI.Text = gems9
        End If

        'art rolls
        Dim art1, art2, art3, art4, art5, art6, art7, art8, art9 As Integer
        art1 = random.Next(1, 100)
        art2 = random.Next(1, 100)
        art3 = random.Next(1, 100)
        art4 = random.Next(1, 100)
        art5 = random.Next(1, 100)
        art6 = random.Next(1, 100)
        art7 = random.Next(1, 100)
        art8 = random.Next(1, 100)
        art9 = random.Next(1, 100)


        For Each txt In {artA, artB, artC, artD, artE, artF, artG, artH, artI}
            txt.Clear()
        Next


        If art1 <= 50 Then
            Dim arts1 As Integer = random.Next(2, 12)
            artA.Text = arts1
        End If
        If art2 <= 20 Then
            Dim arts2 As Integer = random.Next(1, 4)
            artB.Text = arts2
        End If
        If art3 <= 20 Then
            Dim arts3 As Integer = random.Next(1, 3)
            artC.Text = art3
        End If
        If art4 <= 25 Then
            Dim arts4 As Integer = random.Next(1, 6)
            artD.Text = arts4
        End If
        If art5 <= 10 Then
            Dim arts5 As Integer = random.Next(1, 6)
            artE.Text = arts5
        End If
        If art6 <= 10 Then
            Dim arts5 As Integer = random.Next(1, 8)
            artF.Text = arts5
        End If
        If art7 <= 25 Then
            Dim arts7 As Integer = random.Next(1, 6)
            artG.Text = arts7
        End If
        If art8 <= 50 Then
            Dim arts8 As Integer = random.Next(2, 20)
            artH.Text = arts8
        End If
        If art9 <= 50 Then
            Dim arts9 As Integer = random.Next(2, 8)
            artI.Text = arts9
        End If

        'magic rolls
        Dim magic1, magic2, magic3, magic4, magic5, magic6, magic7, magic8, magic9 As Integer
        magic1 = random.Next(1, 100)
        magic2 = random.Next(1, 100)
        magic3 = random.Next(1, 100)
        magic4 = random.Next(1, 100)
        magic5 = random.Next(1, 100)
        magic6 = random.Next(1, 100)
        magic7 = random.Next(1, 100)
        magic8 = random.Next(1, 100)
        magic9 = random.Next(1, 100)


        For Each txt In {magicA, magicB, magicC, magicD, magicE, magicF, magicG, magicH, magicI}
            txt.Clear()
        Next


        If magic1 <= 30 Then
            Dim one As String = ""
            Dim two As String = ""
            Dim three As String = ""
            Dim magicsA1 As Integer = random.Next(1, 100)
            Dim magicsA2 As Integer = random.Next(1, 100)
            Dim magicsA3 As Integer = random.Next(1, 100)
            If magicsA1 <= 100 Then
                one = "Potion"
            End If
            If magicsA2 <= 100 Then
                two = "Ring"
            End If
            If magicsA3 <= 100 Then
                three = "Wand"
            End If
            magicA.Text = Potion()
        End If
        If magic2 <= 10 Then
            Dim magics2 As Integer = random.Next(1, 8)
            magicB.Text = "Magic"
        End If
        If magic3 <= 10 Then
            Dim magics3 As Integer = random.Next(1, 6)
            magicC.Text = "Magic"
        End If
        If magic4 <= 15 Then
            Dim magics4 As Integer = random.Next(1, 10)
            magicD.Text = "Magic"
        End If
        If magic5 <= 25 Then
            Dim magics5 As Integer = random.Next(1, 12)
            magicE.Text = "Magic"
        End If
        If magic6 <= 30 Then
            Dim magics5 As Integer = random.Next(2, 20)
            magicF.Text = "Magic"
        End If
        If magic7 <= 35 Then
            Dim magics7 As Integer = random.Next(3, 18)
            magicG.Text = "Magic"
        End If
        If magic8 <= 15 Then
            Dim magics8 As Integer = random.Next(3, 30)
            magicH.Text = "Magic"
        End If
        If magic9 <= 15 Then
            Dim magics9 As Integer = random.Next(2, 12)
            magicI.Text = "Magic"
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim random As New Random()

        'copper rolls
        CopperJ.Clear()
        CopperO.Clear()
        CopperZ.Clear()


        Dim coppercoin1 As Integer = random.Next(3, 24)
        CopperJ.Text = coppercoin1
        Dim coppercoin2 As Integer = random.Next(1, 4) * 10
        CopperO.Text = coppercoin2
        Dim coppercoin3 As Integer = random.Next(1, 3) * 100
        CopperZ.Text = coppercoin3

        'silver rolls
        SilverK.Clear()
        SilverO.Clear()
        SilverP.Clear()
        SilverZ.Clear()

        Dim silvercoin1 As Integer = random.Next(3, 18)
        SilverK.Text = silvercoin1
        Dim silvercoin2 As Integer = random.Next(1, 3) * 10
        SilverO.Text = silvercoin2
        Dim silvercoin3 As Integer = random.Next(1, 6) * 10
        SilverP.Text = silvercoin3
        Dim silvercoin4 As Integer = random.Next(1, 4) * 100
        SilverZ.Text = silvercoin4

        'gold rolls
        For Each txt In {goldM, goldR, goldW, goldY, goldZ}
            txt.Clear()
        Next

        Dim goldcoin1 As Integer = random.Next(2, 8)
        goldM.Text = goldcoin1
        Dim goldcoin2 As Integer = random.Next(2, 20)
        goldR.Text = goldcoin2
        Dim goldcoin3 As Integer = random.Next(5, 30)
        goldW.Text = goldcoin3
        Dim goldcoin4 As Integer = random.Next(2, 12) * 100
        goldY.Text = goldcoin4
        Dim goldcoin5 As Integer = random.Next(1, 6) * 100
        goldZ.Text = goldcoin5

        'plat rolls
        For Each txt In {platL, platN, platP, platR, platw, platz}
            txt.Clear()
        Next

        Dim platcoin1 As Integer = random.Next(3, 18) * 100
        platL.Text = platcoin1
        Dim platcoin2 As Integer = random.Next(1, 10) * 100
        platN.Text = platcoin2
        Dim platcoin3 As Integer = random.Next(1, 6) * 100
        platP.Text = platcoin3
        Dim platcoin4 As Integer = random.Next(1, 6) * 100
        platR.Text = platcoin4
        Dim platcoin5 As Integer = random.Next(3, 18) * 100
        platw.Text = platcoin5
        Dim platcoin6 As Integer = random.Next(1, 4) * 1000
        platz.Text = platcoin6

        'gem rolls
        Dim gem1, gem2, gem3, gem4, gem5 As Integer
        gem1 = random.Next(1, 100)
        gem2 = random.Next(1, 100)
        gem3 = random.Next(1, 100)

        For Each txt In {gemQ, gemR, gemU, gemW, gemZ}
            txt.Clear()
        Next

        Dim gems1 As Integer = random.Next(1, 4)
        gemQ.Text = gems1
        Dim gems2 As Integer = random.Next(2, 8)
        gemR.Text = gems2
        If gem1 <= 90 Then
            Dim gems3 As Integer = random.Next(1, 6)
            gemU.Text = gem3
        End If
        If gem2 <= 60 Then
            Dim gems4 As Integer = random.Next(2, 16)
            gemW.Text = gems4
        End If
        If gem3 <= 55 Then
            Dim gems5 As Integer = random.Next(1, 6)
            gemZ.Text = gems5
        End If

        'art rolls
        Dim art1, art2, art3, art4 As Integer
        art1 = random.Next(1, 100)
        art2 = random.Next(1, 100)
        art3 = random.Next(1, 100)

        For Each txt In {artR, artU, artW, artZ}
            txt.Clear()
        Next

        Dim arts1 As Integer = random.Next(1, 3)
        artR.Text = arts1
        If art1 <= 80 Then
            Dim arts2 As Integer = random.Next(1, 6)
            artU.Text = arts2
        End If
        If art2 <= 50 Then
            Dim arts3 As Integer = random.Next(1, 8)
            artW.Text = art3
        End If
        If art3 <= 50 Then
            Dim arts4 As Integer = random.Next(2, 12)
            artZ.Text = arts4
        End If

        'magic rolls
        Dim magic1, magic2, magic3 As Integer
        magic1 = random.Next(1, 100)
        magic2 = random.Next(1, 100)
        magic3 = random.Next(1, 100)

        For Each txt In {magicS, magicT, magicU, magicV, magicW, magicX, magicZ}
            txt.Clear()
        Next

        Dim magicsA1 As Integer = random.Next(1, 8)
        magicS.Text = "potions"
        Dim magics2 As Integer = random.Next(1, 4)
        magicT.Text = "scrolls"
        If magic1 <= 70 Then
            magicU.Text = "Magic"
        End If
        magicV.Text = "Any 2 Magic"
        If magic2 <= 60 Then
            magicW.Text = "Any 2 Magic"
        End If
        magicX.Text = "Any 2 Magic"
        If magic3 <= 50 Then
            magicZ.Text = "Any 3 Magic"
        End If

    End Sub

    Public Function Potion() As String

        Dim dictionary As New Dictionary(Of Integer, String)
        dictionary.Add(1, "Elixir Of additional weaponry")
        dictionary.Add(2, "Elixir Of health")
        dictionary.Add(3, "Heroic action Elixir")
        dictionary.Add(4, "Elixir Of Life")
        dictionary.Add(5, "Elixir Of Life")
        dictionary.Add(6, "Elixir of Madness")
        dictionary.Add(7, "Elixir of Madness")
        dictionary.Add(8, "Elixir Of reduction")
        dictionary.Add(9, "Elixir Of youth")
        dictionary.Add(10, "Oil Of acid resistance")
        dictionary.Add(11, "Oil Of armor")
        dictionary.Add(12, "Oil Of dexterity")
        dictionary.Add(13, "Oil Of disenchantment")
        dictionary.Add(14, "Oil Of dragons blood")
        dictionary.Add(15, "Oil of Elemental Invulnerability")
        dictionary.Add(16, "Oil Of Enchantment")
        dictionary.Add(17, "Oil of Etherealness")
        dictionary.Add(18, "Oil of Fiery Burning")
        dictionary.Add(19, "Oil of Fumbling")
        dictionary.Add(20, "Oil of Fumbling")
        dictionary.Add(21, "Oil of High Conquering")
        dictionary.Add(22, "Honeysuckle Oil ")
        dictionary.Add(23, "Oil of Impact")
        dictionary.Add(24, "Oil of Sharpness")
        dictionary.Add(25, "Oil of Slipperiness")
        dictionary.Add(26, "Spikenard Oil ")
        dictionary.Add(27, "Oil of Timelessness")
        dictionary.Add(28, "Oil of Unlocking")
        dictionary.Add(29, "Philter Of glibness")
        dictionary.Add(30, "Philter Of love")
        dictionary.Add(31, "Philter of Persuasiveness")
        dictionary.Add(32, "Philter of Stammering and Stutterin")

        Dim random As New Random()
        Dim item = ""
        Dim potions As Integer = random.Next(1, 32)
        If dictionary.ContainsKey(potions) Then
            ' Write value of the key.
            item = dictionary.Item(potions)
        End If
        Return item

    End Function

End Class

