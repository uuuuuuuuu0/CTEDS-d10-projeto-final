   M S B A M L   `   `   `  ????P  LMega_Sena_Application, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Mega_sena_frontMega_sena_front  5   	        Mega_sena_front.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:Mega_sena_front     5   	     ? Title$  
MainWindow??5   	   $	??900??6   $
??1616??6)    ? 	Resources 5       ?? 
TargetType ?? Property ?? Value ?? 
TargetType ??Name ?? CornerRadius ??Name	 ? 	Resources   Key
 ?? TargetProperty ?? 
TargetName g? Duration t? From	 t? To ?? Triggers P? Property P? Value N? ExitActions ?? BeginStoryboardName ??Name 	 right ?? 
TargetName  left ?? 	Resources  ComboBoxToggleButton ? ColumnDefinitions ?? ElementName ?? Path F?Name  ComboBoxTextBox ?? 	ClickMode d? 	IsChecked ?? Mode ?? RelativeSource J? IsHitTestVisible  ?? SelectionBoxItem! ?? SelectionBoxItemTemplate" ??Name# ?? 
IsReadOnly$ ?? 
IsReadOnly% ?? IsDropDownOpen& ? AllowsTransparency' J? SnapsToDevicePixels( ? ActualWidth) ?? MaxDropDownHeight* K? IsItemsHost-  'System.Windows.Input.KeyboardNavigation+   DirectionalNavigation, P? 
SourceName- ?? Triggers. ?? Padding??%P  '??       7  7  '?? ?    &	     &	 =	    '?? ?	    7  7  '?? ?    ?? 5   
   " ??6   .?5      ??  ? ?? 5      ?? 5      " ??6&   .R?5      ?? .+?5      ? .+?5   "   ?? $ buttonBackground??6)   $??96??5   )   $??46??5   )   ???#D9D9D9$ 24??5   )   $	??0,0q?5   )   5    #   ?? 5!   "   $ button??6)   $??44??5"   )   $??40??5#   )   $ 30??5$   )   $
??Left=?5%   )   $??4,0,0,0q?5&   )   5'   #   5(      ?? 5)      $ content??6/   $??	10,0,10,0q?5*   /   #??z??5+   /   $??center=?5,   /   5-      5.      	 5/      ???? 50      	right  .??51   "   t? $
 Margin?65   $ button??52   5   $ 0:0:0.25D?53   5    4,0,0,054   5    48,0,0,055   5   56   #   57      ?? 58      left  .??59   "   t? $
 Margin?65   $ button??5:   5   $ 0:0:0.25D?5;   5    48,0,0,05<   5    4,0,0,05=   5   5>   #   5?      5@       5A      P? 5B       ?@d?	IsChecked$ FalseY?6;    5C   "   ?? 5D   &   $
 left??67   5E   '   ?? 5F   &   $ right??6Z   8??  5G   '   . ?5I   "   ?? $ button??6)    ? ?? ?#7070705L   #   ?? 5M   "   $ buttonBackground??6)    ? ?? ?#D9D9D95P   #   5Q      P? 5R       ?@d?	IsChecked$
 TrueY?6;    5S   "   ?? 5T   &   $ right??67   5U   '   ?? 5V   &   $
 left??6Y   8?? 5W   '   . ?5Y   "   ?? $ button??6)    ? ??
 ?????5\   #   ?? 5]   "   $ buttonBackground??6)    ? ?? ?#3636365`   #   5a      5c      5e      5f      ?? 5i   
   " ??6    5j      ???? 5k      '??       " ??6   .?5l      ??  ?@??CornerRadius$ 10??65   5m      5n      5o      ?? 5r   
   " d?67   .R?5s      ?  5t      ?? 5u      ?? 5v      $??88 ?6'   .+?5y      ?? $ Border??5z      $??2??5{      $ 	10,10,0,0??5|      $??0,4,4,0q?5~      ???#000000??5}      ?? $ DropDownBorder??$ 
Background?5      ?? 5?      $??0??5?      $ 10,0,0,0??5?      $??0q?5?      $??4,4,0,0q?5?      ???#000000??5?      ?? $ DropDownBorder??$ 
Background?5?      F? 5?      $ Arrow??5?      $??1??5?      $??Center=?5?      $??Center=?5?      =????        ?    ??? ? -1???? Zb??? ? Zb    ? -1 -1	??5?      ?? $ PART_EditableTextBox??$ 
Foreground?5?      5?      5?      ?? 5?   
   " ??62   .R?5?      ?? $ PART_ContentHost??6   $|?False??6/   #??z??6A   5?      ?? 5?   
   " ??6*   .?5?      ??  ?@J?SnapsToDevicePixels$
 true??64   ?? 5?       ?@?OverridesDefaultStyle$
 true??66   ?? 5?       ? ??$
 Auto=?6K   ?? 5?       ? ??$
 Auto=?6I   ?? 5?       ? ??$
 true??6>   ?? 5?       ? ??$	 120??6)   ?? 5?       ? ??$ 20??6*   ?? 5?       ? ?? 6+   ?? $ DropDownBorder??$ 
Background??? 5?       ? ?? 5?      ?? 5?      " ??6&   .R?5?      ? .+?5?      d? $??ToggleButton??5?      8??  $??2??5?      $|?false??5?      $ Press=?5?       5?      ?? $ IsDropDownOpen?$ TwoWay=? ?? *TemplatedParent+5?      ?? 5?      $??ContentSite??6/   $ False??6B   #??z  6\   #??z! 5?      #??z??5?      $??3,3,23,3q?5?      $??Center=?5?      $
??Left=?5?      ?? 5?      $" PART_EditableTextBox??6&   8?? $??Center=?5?      $??Center=?5?      $??3,3,23,3q?5?      $
|?True??5?      $y?Hidden=?5?      #$ z# 5?      ??5?      Z? ??5?      ?? $ DropDownBorder??$ 
Background???5?      ??  ?? *TemplatedParent+$ 
Foreground?5?      ? 5?      $??Popup??5?      $??Bottom=?5?      #??z% 5?      $
& True??5?      $|?False??5?      $??Slide=?5?      .??5?   "   ? $??DropDown??6'   $
' True??5?      #??z( 5?      #??z) 5?      .+?5?   &   ?? $ DropDownBorder??5?   !   $??4,0,4,4q?5?   !   ???#000000??5?   !   ??  ?? *TemplatedParent+$ 
Background?5?   !   ?? 5?   &   $??4,6,4,6q?63   $
' True??6D   .??5?   *   ?? $
* True??65   $+ 	Contained=?6H   5?   '   5?   #   5?      5?       5?      P? 5?       ?@??HasItems$ false??6:   . ?5?   "   ?? $ DropDownBorder??6)    ? ??$ 95??6Z   5?      P? 5?       ? {?$ false??6;   . ?5?   "   ??  ? ?? ?#8888886?   5?      P? 5?       ?@??
IsGrouping$
 true??6<   . ?5?   "   ??  ? ??$ false??6R   5?      P? 5?      $, Popup??6&    ?@?AllowsTransparency$
 true??6]   . ?5?   "   ?? $ DropDownBorder??6)    ?@??CornerRadius$ 0??6]   ?? 5?   "   $ DropDownBorder??6)    ? ??$ 0,2,0,0q?6W   5?      P? 5?       ?@??
IsEditable$
 true??6=   . ?5?   "   ??  ? ??$ false??6>   ?? 5?   "   $ PART_EditableTextBox??6)    ? y?$ Visible=?6a   ?? 5?   "   $ ContentSite??6)    ? y?$ Hidden=?6X   5?      5?      5?      - 5?      5?      ?? 5?   
   " ??6.   .?5?      ??  ?@J?SnapsToDevicePixels$
 true??64   ?? 5?       ? ?? 6+   ??  ?? *TemplatedParent+$ 
Foreground??? 5?       ?@?OverridesDefaultStyle$
 true??66   ?? 5?       ? ?? 5?      ?? 5?      " ??6&   .R?5?      ?? $??Border??6!   $. 2q?5?      $
' true??5?      ._?5?      ?? 5?       5      P? 5      ?@??IsHighlighted$
 true??6?   . ?5  "   ?? $ Border??6)    ? ?? ?	#FF4F4F4F6S   5     P? 5      ? {?$ false??6;   . ?5  "   ??  ? ?? ?#8888886?   5     5     5
     5     5     .??5     ?? $
??1600??6   $	??900??6   .+?5  
   ?? -   5        / ??Name$/ secondColor??5     $
??1600??6*   $??76??67   ???#000000$	??Top=?6X   .+?5     ?? -   5        $??Right=?5     $??Center=?63   $??
0,15,16,15q?6N   5     5     ?? 5  
   -   5        $ titleBorder??5     ???#000000$??0,0,0,0q?6=   ._?5     ? -   5        0 ?Name$0 	mainColor??5     $
??1600??6'   $	??128??64   ???#262626$??Center=?6V   .+?5     ?? -   5        1 ??Name$1 
titleColor??5     $??	46,0,0,16q?5     $
??Left=?5     $??Center=?5     $??64(?5     2 ? Cursor$
2 Hand??5     $??0q?5     ???#262626???#FFFFFF$??
Resultados??5      3 ? Triggers3 5!     :? 5"     4 :? RoutedEvent$4 Button.Click??6'   .[?5#     ?? .??5$  "   ?? .??5%  &   t? $ titleSeparator??69   $
 Margin?5&  7   $ 0:0:0.25D?5'  7    
1165,0,0,05(  7    	435,0,0,05)  7   5*  '   5+  #   5,     5-     5/     ?? 50     -   5        5 ??Name$5 titleSeparator??51     $??	435,0,0,0q?52     ???#000000$??10??54     $	??128??55     $
??Left=?56     58     ?? 59     -   5        $??1249,0,0,16q?5:     $
??Left=?5;     $??Center=?5<     $??64(?5=     $
2 Hand??5>     $??0q?5?     $??Estatísticas??5B     ??5@     ?? $ 
titleColor??$ 
Background???5A     ?? $ 
titleColor??$ 
Foreground?3 5C     :? 5D     $4 Button.Click??6'   .[?5E     ?? .??5F  "   ?? .??5G  &   t? $ titleSeparator??69   $
 Margin?5H  7   $ 0:0:0.25D?5I  7    	585,0,0,05J  7    
1165,0,0,05K  7   5L  '   5M  #   5N     5O     5Q     5R     5S     ? 5T  
   $
??1600??6   $	??156??6   ??6)   ?? $ secondColor??$ 
Background? 5U     ?? 5V     $
??137* ?6#   ?? 5W     $	??56* ?6#   ?? 5X     $??0* ?6#   ?? 5Y     $
??607* ?6#   .+?5[     ?? -   5        $1 returnButton??5\     $??4q?5]     $??24,0,0,0q?5`     $??Center=?5a     $??Center=?5b     $
??Left=?5c     ???#000001$??64??5f     $??<??5g     $??40(?5h     $??
UltraBlack"?5i     $y?	Collapsed=?5k     $??80??5l     $??0??5m     ??5_     ?? $ Busca??$ BorderBrush???5d     ?? $ Busca??$ 
Background? 5o     ??%_   '??       ?? 5p     " ??6   .?5q     ??  ?@??CornerRadius$ 10??69   5r     5s     5t     ?? 5v     -	   5        $" Busca??5w     $??4q?5x     ???#FFFFFF$??	104,0,0,0q?5z     $??Center=?5{     $??Center=?5|     $
??Left=?5}     ???#FFFFFF???#000001$??32(?5?     6 ?? TextAlignment$6 Center=?5?     $	??600??5?     $??80??5?     $??4??5?  1   ?? 5?     -
   5        $1 searchButton??5?     $??4q?5?     $??	330,0,0,0q?5?     $??Center=?5?     $??Center=?5?     $
??Left=?5?     ???#000001$??80??5?     $??80??5?     $??3??5?  ,   ??5?     ?? $ Busca??$ BorderBrush???5?     ?? $ Busca??$ 
Background?.??5?     ?? $&?? /View/img/search-icon-png-21.png??6   $??48??6B    5?     ??%_   '??       ?? 5?     " ??6   .?5?     ??  ?@??CornerRadius$ 10??69   5?     5?     5?     ?? 5?     -   5        7 ??Name$7 cbBox??5?     $??0,0,20,0q?5?     8 ?? 
IsEditable$
8 True??5?     $
# True??5?     $	??128??5?     $	??636??5?     $??Bottom=?5?     $??Right=?5?     $??40(?5?     $??Center=?5?     $??Center=?5?     9 ?? SelectedValue$
9 Name??5?     $??3??5?  >   ??5?     ?? $ 	mainColor??$ 
Background???5?     ?? $ 
titleColor??$ 
Foreground?.@?5?     ?? -   5        $??MegaSena??5?     : ?? 
IsSelected$
: True??6/   $??Center=?5?     ??5?     ?? $ 
titleColor??$ 
Foreground?.??6^   	Mega-Sena6i   ?? 5?     -   5        $??	Lotofacil??5?     $??Center=?60   ??5?     ?? $ 
titleColor??$ 
Foreground?.??6^   
Lotofácil6i   ?? 5?     -   5        $??Quina??5?     $??Center=?6,   ??5?     ?? $ 
titleColor??$ 
Foreground?.??6^   Quina6e   ?? 5?     -   5        $??	Lotomania??5?     $??Center=?60   ??5?     ?? $ 
titleColor??$ 
Foreground?.??6^   	Lotomania6i   ?? 5?     -   5        $??	DuplaSena??5?     $??Center=?60   ??5?     ?? $ 
titleColor??$ 
Foreground?.??6^   
Dupla Sena6j   5?     5?     ?? 5?  
   $??0,4,0,0q?6   ???#000000._?5?     ?? ??6   ?? $ 	mainColor??$ 
Background?.+?5?     ?? -   5        ; ??Name$; auxDiv??5?     $	??Top=?6,   $??	0,-4,24,0q?6D   $??Right=?6W   $	??628??6s   $??5??6   ???#2626266?   ?? 5?     -   5        < ??Name$< resultsWindow??5?     $
??1600??66   $	??520??6C   $y?Visible=?6?   ??6P   ?? $ 	mainColor??$ 
Background?.??5?     ?? -   5        $/ childrenHolder??5?  !   5?     5?     ?? 5?     -   5        $< statisticsWindow??5?     $
??1600??69   $	??520??6F   $y?	Collapsed=?6S   ??6j   ?? $ 	mainColor??.??5?     ? $
??1600??6   .+?5?     ?? -   5        $ ??Gerar números aleatórios??5?  !   ???#FFFFFF???#000000$??32(?5?     $??0q?5?     $??	40,40,0,0q?5?     $	??Top=?5?     $
??Left=?5?     $	??600??5?     $	??100??5?     $
2 Hand??5?     5?     ?? 5?     -   5        $1 randomNumber??5?     $??
0,40,196,0q?5?     $	??Top=?5?     $??Right=?5?     $??32(?5?     $??0q?5?     $	??672??5?     $	??100??5?     $
2 Hand??5?     ???#FFFFFF???#494949$??XX XX XX XX XX XX??5?     ?? 5?     -   5        $1 	clipBoard??5?     $??	0,40,64,0q?5?     $	??Top=?5?     $??Right=?5?     $??32(?5?     $??0q?5?     $	??100??5?     $	??100??5?     $
2 Hand??5?     ???#FFFFFF???#494949.??5?     ?? $??64??6$   $??/View/img/clipboard2.png??6/   5?     ?? 5?     -   5        $; titleTwo??5?  $   $	??Top=?5?  $   $
??Left=?5?  $   $??
64,172,0,0q?5?  $   $??40(?5?  $   ???#FFFFFF$	??300??5?  $   $	??100??5?  $   = ?? TextAlignment$= Center=?5?  $   Maiores Prêmios6M   ?? 5?     -   5        $/ stackContainer??5?  %   $??0, 240, 0, 0q?5?  %   .+?5?     ?? -   5        $/ childHolderTwo??5?  )   $??0,0,0,0q?5?  )   $
??1600??5   )   5     ?? 5     -   5        $; mostSortedTxtBlock??5  (   $??48(?5  !   $??64, 0, 0, 64q?5  !   ??5  !   ?? $ titleTwo??$ 
Foreground?Números mais sorteados5  9   ? 5
     $	??720??6#   > ? RowDefinitions> 5  "   ?? 5  &   $??80 ?64   6B   ?? 5  &   $	??112 ?64   6C   ?? 5  &   $	??112 ?64   6C   ?? 5  &   $	??112 ?64   6C    5  "   ?? 5  &   $	??112 ?67   6E   ?? 5  &   $??* ?67   6C   ?? 5  &   $??* ?67   6C   .+?5  "   ?? $??4q?5  %   $??0??5  %   $??1??5  %   ??5  %   ?? $ 	mainColor??$ 
Background?._?5  &   ?? 
???????$??40(?5"  -   $= Center=?5#  -   $??Stretch=?5$  -   $??Stretch=?5%  -   ? ?? Padding$? 28q?5&  -   $
??auto??5'  -   $
??auto??5(  -   ???#1a1a1a1º5-  '   5.  #   ?? 50  "   $??4q?51  %   $??0??53  %   $??2??54  %   ??52  %   ?? $ 	mainColor??$ 
Background?._?56  &   ?? 
???????$??40(?59  -   $= Center=?5:  -   $??Stretch=?5;  -   $??Stretch=?5<  -   $? 28q?5=  -   $
??auto??5>  -   $
??auto??5?  -   ???#1a1a1a2º5D  '   5E  #   ?? 5G  "   $??4q?5H  %   $??0??5J  %   $??3??5K  %   ??5I  %   ?? $ 	mainColor??$ 
Background?._?5M  &   ?? 
???????$??40(?5P  -   $= Center=?5Q  -   $??Stretch=?5R  -   $??Stretch=?5S  -   $? 28q?5T  -   $
??auto??5U  -   $
??auto??5V  -   ???#1a1a1a3º5[  '   5\  #   ?? 5^  "   $??4q?5_  %   $??1??5a  %   $??0??5b  %   ??5`  %   ?? $ 	mainColor??$ 
Background?._?5d  *   ?? 
???????$??28(?5g  -   $= Center=?5h  -   $??Stretch=?5i  -   $??Stretch=?5j  -   $? 12q?5k  -   $
??auto??5l  -   $
??auto??5m  -   	Número5p  +   5q  #   ?? 5s  "   $??4q?5t  %   $??2??5v  %   $??0??5w  %   ??5u  %   ?? $ 	mainColor??$ 
Background?._?5y  &   ?? 
???????$??28(?5|  -   $= Center=?5}  -   $??Stretch=?5~  -   $??Stretch=?5  -   $? 12q?5?  -   $
??auto??5?  -   $
??auto??5?  -   Nº de vezes sorteado5?  '   5?  #   ?? 5?  "   $??4q?5?  %   $??1??5?  %   $??1??5?  %   ??5?  %   ?? $ 	mainColor??$ 
Background?._?5?  &   ?? -   5        $; Num01??5?  -   
??????????#222222$??56(?5?  -   $??SemiBold"?5?  -   $= Center=?5?  -   $??Stretch=?5?  -   $??Stretch=?5?  -   $? 12q?5?  -   $
??auto??5?  -   $
??auto??5?  -   5?  '   5?  #   ?? 5?  "   $??4q?5?  %   $??1??5?  %   $??2??5?  %   ??5?  %   ?? $ 	mainColor??$ 
Background?._?5?  &   ?? -   5        $; Num02??5?  -   
??????????#222222$??56(?5?  -   $??SemiBold"?5?  -   $= Center=?5?  -   $??Stretch=?5?  -   $??Stretch=?5?  -   $? 12q?5?  -   $
??auto??5?  -   $
??auto??5?  -   5?  '   5?  #   ?? 5?  "   $??4q?5?  %   $??1??5?  %   $??3??5?  %   ??5?  %   ?? $ 	mainColor??$ 
Background?._?5?  &   ?? -   5        $; Num03??5?  -   
??????????#222222$??56(?5?  -   $??SemiBold"?5?  -   $= Center=?5?  -   $??Stretch=?5?  -   $??Stretch=?5?  -   $? 12q?5?  -   $
??auto??5?  -   $
??auto??5?  -   5?  '   5?  #   ?? 5?  "   $??4q?5?  %   $??2??5?  %   $??1??5?  %   ??5?  %   ?? $ 	mainColor??$ 
Background?._?5?  &   ?? -   5        $; Quant01??5?  -   
??????????#111111$??40(?5?  -   $= Center=?5?  -   $??Stretch=?5?  -   $??Stretch=?5?  -   $? 12q?5?  -   $
??auto??5?  -   $
??auto??5?  -   5?  '   5?  #   ?? 5?  "   $??4q?5?  %   $??2??5?  %   $??2??5?  %   ??5?  %   ?? $ 	mainColor??$ 
Background?._?5?  &   ?? -    5        $; Quant02??5?  -   
??????????#111111$??40(?5?  -   $= Center=?5?  -   $??Stretch=?5?  -   $??Stretch=?5?  -   $? 12q?5?  -   $
??auto??5?  -   $
??auto??5?  -   5?  '   5?  #   ?? 5?  "   $??4q?5?  %   $??2??5?  %   $??3??5?  %   ??5?  %   ?? $ 	mainColor??$ 
Background?._?5  &   ?? -!   5        $; Quant03??5  -   
??????????#020202$??40(?5  -   $= Center=?5  -   $??Stretch=?5  -   $??Stretch=?5	  -   $? 20q?5
  -   $
??auto??5  -   $
??auto??5  -   5  '   5  #   5     ? 5     $	??160??6#   62   5     5     5     5     5     5     5     