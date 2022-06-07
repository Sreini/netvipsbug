// See https://aka.ms/new-console-template for more information
var chollaSansItalic = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "fonts\\ChollaSans-Italic.ttf");
var chollaSansThin = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "fonts\\ChollaSans-Thin.ttf");
var kremlinpro = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "fonts\\Kremlin II Pro-Regular.ttf");


var text3 = NetVips.Image.Text($"<span bgcolor=\"#DD0000\" color=\"#FFFFFF\" bgalpha=\"1\">Hello World</span>", "Kremlin II Pro Regular 12", 848, null, null, true, 300, null, 11, kremlinpro);

var text2 = NetVips.Image.Text($"<span bgcolor=\"#DD0000\" color=\"#FFFFFF\" bgalpha=\"1\">Hello World</span>", "ChollaSans-Thin 12", 848, null, null, true, 300, null, 11, chollaSansThin);

var text = NetVips.Image.Text($"<span bgcolor=\"#DD0000\" color=\"#FFFFFF\" bgalpha=\"1\">Hello World</span>", "ChollaSans 12", 848, null, null, true, 300, null, 11, chollaSansItalic);
text3.Pngsave("C:\\Users\\Public\\Desktop\\test3.png");
text2.Pngsave("C:\\Users\\Public\\Desktop\\test2.png");
text.Pngsave("C:\\Users\\Public\\Desktop\\test.png");
