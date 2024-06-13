Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Text
Imports System.Threading
Imports System.Windows.Forms
Imports BlackMiner.Properties

Namespace Software
	' Token: 0x02000007 RID: 7
	Public Partial Class FormFour
		Inherits Form

		' Token: 0x06000031 RID: 49 RVA: 0x0000AD9C File Offset: 0x00008F9C
		Public Sub New()
			Me.InitializeComponent()
			Me.cancellationTokenSource = New CancellationTokenSource()
			Me.random = New Random()
			Me.tries = 0
			Me.isMining = False
			Me.foundCount = 0
			Me.textBuilder = New StringBuilder()
			Me.words = New String() { "sheriff", "antenna", "brain", "gorilla", "guess", "axis", "picture", "output", "tree", "people", "fly", "taxi", "clip", "frown", "kit", "expect", "piece", "maximum", "little", "globe", "judge", "vivid", "segment", "acid", "scatter", "trade", "garlic", "impulse", "cabin", "edit", "suggest", "frame", "talk", "bean", "urban", "tissue", "know", "wreck", "bone", "uniform", "predict", "glare", "thing", "topple", "street", "various", "frog", "dose", "mobile", "crazy", "august", "wave", "catalog", "drastic", "dial", "iron", "extend", "ramp", "ghost", "stuff", "daring", "random", "gravity", "mutual", "identify", "sauce", "wasp", "zebra", "youth", "cricket", "letter", "permit", "vote", "nature", "catalog", "name", "book", "camera", "record", "planet", "tumble", "task", "month", "ugly", "trend", "affair", "sniff", "wheat", "oblige", "case", "funny", "jewel", "oven", "forum", "chalk", "fault", "barely", "legal", "enough", "vintage", "firm", "curious", "black", "enjoy", "donor", "three", "lake", "blind", "trophy", "relax", "game", "brush", "document", "private", "dream", "proof", "guide", "kind", "possible", "upon", "leopard", "latin", "security", "anxiety", "major", "blood", "recycle", "involve", "stuff", "affair", "describe", "hip", "stay", "slot", "lecture", "sort", "neglect", "artwork", "attract", "dawn", "drop", "muscle", "reveal", "gather", "toy", "twist", "choice", "say", "used", "advice", "require", "fame", "advance", "effort", "become", "april", "medal", "security", "inside", "deposit", "fluid", "buyer", "yellow", "matrix", "pottery", "citizen", "mercy", "define", "shell", "minor", "guess", "casual", "fancy", "agent", "about", "myth", "habit", "dignity", "forest", "task", "heavy", "smile", "equip", "luggage", "blind", "cigar", "guard", "book", "coconut", "split", "choice", "grape", "grief", "lonely", "gown", "mystery", "sphere", "universe", "tube", "erase", "prepare", "hedgehog", "scheme", "level", "giant", "autumn", "tone", "night", "subway", "lemon", "gossip", "bulb", "donkey", "gospel", "proud", "novel", "summer", "little", "suffer", "inmate", "know", "thank", "thought", "quiz", "stick", "mansion", "purse", "jaguar", "female", "test", "climb", "agree", "bitter", "addict", "bachelor", "process", "teach", "tomorrow", "brave", "exchange", "appear", "gold", "expect", "duty", "jump", "spread", "turn", "seminar", "west", "ride", "sweet", "subway", "century", "expose", "about", "violin", "clarify", "vessel", "innocent", "wrap", "gauge", "sponsor", "sudden", "margin", "proof", "collect", "absent", "limit", "uncover", "welcome", "situate", "acquire", "bulb", "pudding", "sketch", "fish", "lounge", "park", "range", "toy", "enact", "joke", "wait", "oval", "live", "mad", "motor", "social", "evoke", "uniform", "prepare", "join", "illness", "rude", "feed", "rain", "into", "repair", "purse", "basket", "card", "velvet", "jar", "inflict", "thing", "dutch", "used", "piano", "adapt", "solve", "govern", "enable", "jealous", "enrich", "basket", "anger", "kite", "sight", "picture", "remain", "tennis", "album", "enroll", "sock", "quantum", "suit", "indoor", "token", "naive", "clump", "scan", "crush", "review", "carry", "start", "family", "cigar", "clock", "avoid", "dinner", "volcano", "useful", "project", "crane", "print", "glow", "lift", "across", "earth", "hurt", "repeat", "satoshi", "actor", "excuse", "liberty", "discover", "wisdom", "dream", "silent", "document", "buddy", "middle", "small", "cinnamon", "snake", "arena", "round", "flag", "wagon", "judge", "scare", "proof", "mixed", "effort", "sorry", "filter", "adjust", "disorder", "bid", "lecture", "unknown", "mushroom", "patient", "banner", "spice", "boil", "speed", "museum", "between", "romance", "pistol", "need", "casual", "bring", "chapter", "remember", "night", "boost", "ahead", "vibrant", "apart", "vacant", "salon", "liar", "fiber", "void", "burger", "clap", "face", "clinic", "blanket", "awkward", "lemon", "drift", "possible", "scorpion", "fiction", "twist", "kit", "can", "forest", "meadow", "want", "sock", "note", "busy", "gorilla", "crouch", "laptop", "grunt", "street", "primary", "south", "more", "gun", "save", "senior", "parrot", "borrow", "episode", "lab", "donkey", "absorb", "swap", "choose", "angle", "dragon", "fall", "recall", "faint", "clown", "ethics", "deliver", "seat", "west", "barrel", "barely", "tonight", "never", "half", "consider", "myth", "grunt", "banana", "cattle", "mercy", "embrace", "grid", "piece", "circle", "decorate", "almost", "bridge", "ill", "cement", "clog", "ranch", "skate", "decide", "damage", "skill", "camp", "motor", "sock", "expire", "tone", "diary", "elephant", "glue", "today", "twice", "icon", "total", "common", "vessel", "slide", "ritual", "supreme", "avocado", "human", "weekend", "smoke", "net", "prepare", "grocery", "okay", "expand", "rigid", "word", "cruel", "easy", "window", "above", "possible", "dirt", "blossom", "fruit", "rubber", "kit", "ginger", "weather", "wife", "second", "comfort", "citizen", "prevent", "piece", "woman", "hybrid", "shy", "inspire", "cluster", "lyrics", "very", "fall", "twice", "length", "afford", "photo", "luxury", "cloud", "town", "easily", "country", "wish", "polar", "knee", "decorate", "height", "garment", "card", "motor", "agree", "truck", "cannon", "main", "taste", "armed", "rent", "kick", "wife", "hope", "miracle", "ancient", "pass", "method", "acoustic", "install", "oppose", "slice", "fine", "help", "link", "what", "range", "hospital", "reopen", "fetch", "apology", "frost", "survey", "rib", "milk", "drink", "diary", "stamp", "tuna", "grape", "forum", "chuckle", "ring", "ready", "hundred", "ritual", "educate", "swarm", "balance", "edge", "feed", "salmon", "decline", "tone", "top", "capable", "sing", "chef", "lottery", "lunar", "wasp", "produce", "employ", "gadget", "giggle", "mother", "cream", "jelly", "memory", "boil", "pole", "spice", "naive", "track", "feature", "basket", "unfold", "ceiling", "pyramid", "fun", "winner", "unable", "wonder", "early", "total", "lunar", "monster", "vivid", "ritual", "fluid", "this", "very", "grain", "spy", "motion", "cheese", "into", "dog", "album", "donate", "nerve", "tiny", "dune", "wrong", "voice", "ostrich", "bullet", "list", "present", "happy", "void", "wolf", "rigid", "method", "again", "hurdle", "twist", "outside", "welcome", "mention", "canoe", "chaos", "chuckle", "warm", "lemon", "top", "sketch", "dog", "hotel", "excuse", "innocent", "van", "lobster", "pelican", "daughter", "pipe", "clock", "swap", "brass", "tool", "large", "final", "midnight", "scene", "check", "cabbage", "tide", "depend", "track", "cycle", "sun", "cream", "faculty", "wonder", "fortune", "place", "trip", "enlist", "gaze", "unfold", "loop", "affair", "worth", "early", "animal", "merry", "tilt", "grow", "load", "list", "drum", "stone", "gorilla", "inflict", "six", "april", "orbit", "trust", "enough", "cost", "lesson", "base", "tuna", "fresh", "unique", "morning", "decrease", "cactus", "tree", "thought", "rich", "bar", "pitch", "skate", "cycle", "army", "human", "garden", "fox", "feature", "resource", "thought", "film", "nasty", "runway", "sad", "choice", "piece", "omit", "snap", "merge", "engage", "wrap", "draft", "swift", "word", "mixture", "guitar", "spawn", "resemble", "topple", "tent", "chat", "slab", "police", "tiny", "unknown", "catch", "right", "grace", "island", "reject", "benefit", "giant", "key", "scale", "pear", "weather", "pyramid", "express", "mutual", "need", "market", "gym", "alley", "pony", "east", "favorite", "other", "maple", "neglect", "accident", "fox", "angle", "master", "nothing", "bleak", "wish", "move", "short", "rent", "garage", "heart", "flight", "whisper", "brown", "message", "mango", "scan", "fever", "aunt", "firm", "hammer", "spend", "crisp", "receive", "grit", "thing", "marble", "bomb", "tilt", "mistake", "cluster", "increase", "wrap", "lock", "side", "sword", "hurry", "carpet", "bone", "utility", "spray", "test", "plug", "furnace", "motor", "exist", "disease", "gown", "bean", "response", "issue", "point", "decrease", "smooth", "execute", "veteran", "clown", "alter", "forum", "mom", "dinosaur", "course", "cube", "crisp", "armed", "rapid", "bulb", "custom", "zebra", "myself", "right", "impulse", "then", "toward", "improve", "copper", "design", "cruise", "force", "into", "sad", "episode", "enemy", "mushroom", "chalk", "vendor", "car", "image", "drop", "say", "defy", "level", "bird", "join", "educate", "upper", "radio", "avocado", "dynamic", "police", "genius", "road", "cattle", "sauce", "sing", "enter", "injury", "return", "gather", "family", "all", "lazy", "arrive", "junk", "illegal", "oblige", "gentle", "hobby", "practice", "hover", "shallow", "outside", "infant", "logic", "special", "life", "ugly", "spin", "enrich", "project", "disease", "cool", "flower", "extra", "snow", "frog", "labor", "brain", "heavy", "hen", "flee", "habit", "erupt", "merit", "metal", "sport", "shine", "ugly", "mom", "marine", "choose", "comic", "peasant", "purse", "shadow", "tool", "panther", "good", "cancel", "fame", "diagram", "false", "strategy", "spring", "image", "museum", "citizen", "kite", "decline", "kid", "decide", "must", "wage", "cabbage", "engine", "mimic", "organ", "process", "swallow", "ordinary", "machine", "goose", "sweet", "badge", "bench", "winner", "try", "better", "have", "knock", "flee", "moral", "action", "stage", "purpose", "squirrel", "tree", "culture", "maximum", "clap", "reward", "penalty", "motor", "sort", "strike", "reward", "shrug", "blossom", "device", "canyon", "push", "age", "dream", "rally", "student", "sound", "broccoli", "stool", "victory", "wolf", "illegal", "wine", "segment", "decorate", "input", "jump", "business", "wear", "vintage", "tourist", "milk", "search", "surround", "deer", "vivid", "end", "catalog", "reward", "spice", "cool", "develop", "canoe", "record", "cook", "slab", "drink", "fall", "entry", "food", "clever", "wreck", "vessel", "rack", "area", "senior", "desert", "term", "name", "bike", "steel", "clerk", "sell", "unhappy", "few", "imitate", "toward", "hood", "employ", "tissue", "student", "middle", "raccoon", "hammer", "jazz", "elite", "benefit", "vivid", "vote", "lottery", "soccer", "just", "donor", "able", "laundry", "afford", "alpha", "very", "cactus", "army", "salad", "among", "pause", "enact", "venue", "any", "bicycle", "banana", "negative", "pigeon", "company", "bubble", "remove", "census", "crunch", "angry", "ignore", "drink", "control", "laugh", "say", "reunion", "scrub", "wire", "spread", "diary", "spray", "lawn", "reduce", "actor", "ship", "fault", "cube", "spawn", "member", "civil", "goat", "disagree", "six", "maid", "dress", "wrist", "goose", "want", "clump", "fatal", "hunt", "winter", "extra", "smart", "call", "ghost", "sense", "erode", "input", "dice", "print", "speak", "latin", "various", "reduce", "orphan", "magnet", "convince", "bridge", "manage", "ramp", "silly", "ostrich", "mule", "effort", "glass", "cabin", "alarm", "zebra", "rug", "view", "cat", "fortune", "matter", "increase", "trophy", "mandate", "select", "clever", "tube", "pledge" }
		End Sub

		' Token: 0x06000032 RID: 50 RVA: 0x0000E394 File Offset: 0x0000C594
		Private Function GenerateRandomWords() As String
			Dim wordBuilder As StringBuilder = New StringBuilder("Wallet check: ")
			For i As Integer = 0 To 12 - 1
				Dim index As Integer = Me.random.[Next](Me.words.Length)
				Dim word As String = Me.words(index).PadRight(12)
				wordBuilder.Append(word)
			Next
			Dim result As String = wordBuilder.ToString().TrimEnd(Array.Empty(Of Char)())
			result = String.Join(" ", result.Split(New Char() { " "c }, StringSplitOptions.RemoveEmptyEntries))
			Return result + Environment.NewLine
		End Function

		' Token: 0x06000033 RID: 51 RVA: 0x0000E420 File Offset: 0x0000C620
		Private Sub FormFour_Load(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000034 RID: 52 RVA: 0x0000E424 File Offset: 0x0000C624
		Private Function GetCheckedCount() As Integer
			Dim checkedCount As Integer = 0
			If Me.checkBox1.Checked Then
				checkedCount += 1
			End If
			If Me.checkBox2.Checked Then
				checkedCount += 1
			End If
			If Me.checkBox3.Checked Then
				checkedCount += 1
			End If
			If Me.checkBox4.Checked Then
				checkedCount += 1
			End If
			If Me.checkBox5.Checked Then
				checkedCount += 1
			End If
			If Me.checkBox6.Checked Then
				checkedCount += 1
			End If
			Return checkedCount
		End Function

		' Token: 0x06000035 RID: 53 RVA: 0x0000E49C File Offset: 0x0000C69C
		Private Sub btnStart_Click(sender As Object, e As EventArgs)
			Dim checkedCount As Integer = Me.GetCheckedCount()
			If checkedCount = 0 Then
				MessageBox.Show("Please select a valid currency.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
				Return
			End If
			If checkedCount > 4 Then
				MessageBox.Show("Your version only supports 4 blockchain.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
				Return
			End If
			Me.isMining = True
			Me.btnStart.Enabled = False
			Me.btnStop.Enabled = True
			Me.cancellationTokenSource = New CancellationTokenSource()
			Me.textBoxOutput.Clear()
			Try
				Me.StartMining(Me.cancellationTokenSource.Token)
			Catch ex As OperationCanceledException
				Me.textBoxOutput.AppendText("Operation canceled." & vbLf)
			Finally
				Me.isMining = False
				Me.btnStart.Enabled = False
			End Try
		End Sub

		' Token: 0x06000036 RID: 54 RVA: 0x0000E56C File Offset: 0x0000C76C
		Private Sub btnStop_Click(sender As Object, e As EventArgs)
			Dim <btnStop_Click>d__ As FormFour.<btnStop_Click>d__12
			<btnStop_Click>d__.<>t__builder = AsyncVoidMethodBuilder.Create()
			<btnStop_Click>d__.<>4__this = Me
			<btnStop_Click>d__.<>1__state = -1
			<btnStop_Click>d__.<>t__builder.Start(Of FormFour.<btnStop_Click>d__12)(<btnStop_Click>d__)
		End Sub

		' Token: 0x06000037 RID: 55 RVA: 0x0000E5A4 File Offset: 0x0000C7A4
		Private Sub StartMining(token As CancellationToken)
			Dim <StartMining>d__ As FormFour.<StartMining>d__13
			<StartMining>d__.<>t__builder = AsyncVoidMethodBuilder.Create()
			<StartMining>d__.<>4__this = Me
			<StartMining>d__.token = token
			<StartMining>d__.<>1__state = -1
			<StartMining>d__.<>t__builder.Start(Of FormFour.<StartMining>d__13)(<StartMining>d__)
		End Sub

		' Token: 0x06000038 RID: 56 RVA: 0x0000E5E3 File Offset: 0x0000C7E3
		Private Sub textBoxOutput_TextChanged(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x06000039 RID: 57 RVA: 0x0000E5E5 File Offset: 0x0000C7E5
		Private Sub DisplayCounter(counter As Integer)
			Me.lblCounter.Text = String.Format("Checked: {0}", counter)
		End Sub

		' Token: 0x0600003A RID: 58 RVA: 0x0000E602 File Offset: 0x0000C802
		Private Sub button1_Click(sender As Object, e As EventArgs)
			New info().Show()
		End Sub

		' Token: 0x0600003B RID: 59 RVA: 0x0000E60E File Offset: 0x0000C80E
		Private Sub checkBox1_CheckedChanged(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x04000040 RID: 64
		Private cancellationTokenSource As CancellationTokenSource

		' Token: 0x04000041 RID: 65
		Private random As Random

		' Token: 0x04000042 RID: 66
		Private tries As Integer

		' Token: 0x04000043 RID: 67
		Private isMining As Boolean

		' Token: 0x04000044 RID: 68
		Private foundCount As Integer

		' Token: 0x04000045 RID: 69
		Private words As String()

		' Token: 0x04000046 RID: 70
		Private textBuilder As StringBuilder
	End Class
End Namespace
