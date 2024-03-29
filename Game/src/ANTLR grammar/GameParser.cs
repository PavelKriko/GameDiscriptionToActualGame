//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.13.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from c:/Users/azazi/Desktop/GameInitialization/Game/src/ANTLR grammar/Game.g4 by ANTLR 4.13.1

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using System;
using System.IO;
using System.Text;
using System.Diagnostics;
using System.Collections.Generic;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.13.1")]
[System.CLSCompliant(false)]
public partial class GameParser : Parser {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		INCLUDE=1, PROPERTIES=2, GAMESTART=3, GAMEEND=4, INIT=5, WORD=6, COMMAND=7, 
		GAMECOMMANDS=8, CONDITIONCOMMAND=9, IF=10, THEN=11, ELSE=12, WHITESPACE=13, 
		NEWLINE=14;
	public const int
		RULE_game = 0, RULE_initGame = 1, RULE_objectWithProperty = 2, RULE_objectProperties = 3, 
		RULE_property = 4, RULE_chainOfCommands = 5, RULE_simplecommand = 6, RULE_conditioncommand = 7;
	public static readonly string[] ruleNames = {
		"game", "initGame", "objectWithProperty", "objectProperties", "property", 
		"chainOfCommands", "simplecommand", "conditioncommand"
	};

	private static readonly string[] _LiteralNames = {
		null, "'Include'", "'Properties'", "'Start'", "'End'", "'Init'", null, 
		"'Command'", null, "'ConditionCommand'", "'If'", "'Then'", "'Else'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "INCLUDE", "PROPERTIES", "GAMESTART", "GAMEEND", "INIT", "WORD", 
		"COMMAND", "GAMECOMMANDS", "CONDITIONCOMMAND", "IF", "THEN", "ELSE", "WHITESPACE", 
		"NEWLINE"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "Game.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override int[] SerializedAtn { get { return _serializedATN; } }

	static GameParser() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}

		public GameParser(ITokenStream input) : this(input, Console.Out, Console.Error) { }

		public GameParser(ITokenStream input, TextWriter output, TextWriter errorOutput)
		: base(input, output, errorOutput)
	{
		Interpreter = new ParserATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	public partial class GameContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode GAMESTART() { return GetToken(GameParser.GAMESTART, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public InitGameContext initGame() {
			return GetRuleContext<InitGameContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode GAMEEND() { return GetToken(GameParser.GAMEEND, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Eof() { return GetToken(GameParser.Eof, 0); }
		public GameContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_game; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IGameVisitor<TResult> typedVisitor = visitor as IGameVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitGame(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public GameContext game() {
		GameContext _localctx = new GameContext(Context, State);
		EnterRule(_localctx, 0, RULE_game);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 16;
			Match(GAMESTART);
			State = 17;
			initGame();
			State = 18;
			Match(GAMEEND);
			State = 19;
			Match(Eof);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class InitGameContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode INIT() { return GetToken(GameParser.INIT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ObjectWithPropertyContext[] objectWithProperty() {
			return GetRuleContexts<ObjectWithPropertyContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public ObjectWithPropertyContext objectWithProperty(int i) {
			return GetRuleContext<ObjectWithPropertyContext>(i);
		}
		public InitGameContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_initGame; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IGameVisitor<TResult> typedVisitor = visitor as IGameVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitInitGame(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public InitGameContext initGame() {
		InitGameContext _localctx = new InitGameContext(Context, State);
		EnterRule(_localctx, 2, RULE_initGame);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 21;
			Match(INIT);
			State = 23;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			do {
				{
				{
				State = 22;
				objectWithProperty();
				}
				}
				State = 25;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			} while ( _la==WORD );
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ObjectWithPropertyContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode WORD() { return GetToken(GameParser.WORD, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode PROPERTIES() { return GetToken(GameParser.PROPERTIES, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ObjectPropertiesContext objectProperties() {
			return GetRuleContext<ObjectPropertiesContext>(0);
		}
		public ObjectWithPropertyContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_objectWithProperty; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IGameVisitor<TResult> typedVisitor = visitor as IGameVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitObjectWithProperty(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ObjectWithPropertyContext objectWithProperty() {
		ObjectWithPropertyContext _localctx = new ObjectWithPropertyContext(Context, State);
		EnterRule(_localctx, 4, RULE_objectWithProperty);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 27;
			Match(WORD);
			State = 28;
			Match(PROPERTIES);
			State = 29;
			objectProperties();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ObjectPropertiesContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] WORD() { return GetTokens(GameParser.WORD); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode WORD(int i) {
			return GetToken(GameParser.WORD, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public PropertyContext[] property() {
			return GetRuleContexts<PropertyContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public PropertyContext property(int i) {
			return GetRuleContext<PropertyContext>(i);
		}
		public ObjectPropertiesContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_objectProperties; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IGameVisitor<TResult> typedVisitor = visitor as IGameVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitObjectProperties(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ObjectPropertiesContext objectProperties() {
		ObjectPropertiesContext _localctx = new ObjectPropertiesContext(Context, State);
		EnterRule(_localctx, 6, RULE_objectProperties);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 33;
			ErrorHandler.Sync(this);
			_alt = 1;
			do {
				switch (_alt) {
				case 1:
					{
					{
					State = 31;
					Match(WORD);
					State = 32;
					property();
					}
					}
					break;
				default:
					throw new NoViableAltException(this);
				}
				State = 35;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,1,Context);
			} while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER );
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class PropertyContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode INCLUDE() { return GetToken(GameParser.INCLUDE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ChainOfCommandsContext chainOfCommands() {
			return GetRuleContext<ChainOfCommandsContext>(0);
		}
		public PropertyContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_property; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IGameVisitor<TResult> typedVisitor = visitor as IGameVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitProperty(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public PropertyContext property() {
		PropertyContext _localctx = new PropertyContext(Context, State);
		EnterRule(_localctx, 8, RULE_property);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 37;
			Match(INCLUDE);
			State = 38;
			chainOfCommands();
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ChainOfCommandsContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public SimplecommandContext[] simplecommand() {
			return GetRuleContexts<SimplecommandContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public SimplecommandContext simplecommand(int i) {
			return GetRuleContext<SimplecommandContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ConditioncommandContext[] conditioncommand() {
			return GetRuleContexts<ConditioncommandContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public ConditioncommandContext conditioncommand(int i) {
			return GetRuleContext<ConditioncommandContext>(i);
		}
		public ChainOfCommandsContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_chainOfCommands; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IGameVisitor<TResult> typedVisitor = visitor as IGameVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitChainOfCommands(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ChainOfCommandsContext chainOfCommands() {
		ChainOfCommandsContext _localctx = new ChainOfCommandsContext(Context, State);
		EnterRule(_localctx, 10, RULE_chainOfCommands);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 42;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			do {
				{
				State = 42;
				ErrorHandler.Sync(this);
				switch (TokenStream.LA(1)) {
				case COMMAND:
					{
					State = 40;
					simplecommand();
					}
					break;
				case CONDITIONCOMMAND:
					{
					State = 41;
					conditioncommand();
					}
					break;
				default:
					throw new NoViableAltException(this);
				}
				}
				State = 44;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			} while ( _la==COMMAND || _la==CONDITIONCOMMAND );
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class SimplecommandContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COMMAND() { return GetToken(GameParser.COMMAND, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode GAMECOMMANDS() { return GetToken(GameParser.GAMECOMMANDS, 0); }
		public SimplecommandContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_simplecommand; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IGameVisitor<TResult> typedVisitor = visitor as IGameVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitSimplecommand(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public SimplecommandContext simplecommand() {
		SimplecommandContext _localctx = new SimplecommandContext(Context, State);
		EnterRule(_localctx, 12, RULE_simplecommand);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 46;
			Match(COMMAND);
			State = 47;
			Match(GAMECOMMANDS);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ConditioncommandContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode CONDITIONCOMMAND() { return GetToken(GameParser.CONDITIONCOMMAND, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode IF() { return GetToken(GameParser.IF, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode THEN() { return GetToken(GameParser.THEN, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public SimplecommandContext[] simplecommand() {
			return GetRuleContexts<SimplecommandContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public SimplecommandContext simplecommand(int i) {
			return GetRuleContext<SimplecommandContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ConditioncommandContext[] conditioncommand() {
			return GetRuleContexts<ConditioncommandContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public ConditioncommandContext conditioncommand(int i) {
			return GetRuleContext<ConditioncommandContext>(i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ELSE() { return GetToken(GameParser.ELSE, 0); }
		public ConditioncommandContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_conditioncommand; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IGameVisitor<TResult> typedVisitor = visitor as IGameVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitConditioncommand(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ConditioncommandContext conditioncommand() {
		ConditioncommandContext _localctx = new ConditioncommandContext(Context, State);
		EnterRule(_localctx, 14, RULE_conditioncommand);
		int _la;
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 49;
			Match(CONDITIONCOMMAND);
			State = 50;
			Match(IF);
			State = 53;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			do {
				{
				State = 53;
				ErrorHandler.Sync(this);
				switch (TokenStream.LA(1)) {
				case COMMAND:
					{
					State = 51;
					simplecommand();
					}
					break;
				case CONDITIONCOMMAND:
					{
					State = 52;
					conditioncommand();
					}
					break;
				default:
					throw new NoViableAltException(this);
				}
				}
				State = 55;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			} while ( _la==COMMAND || _la==CONDITIONCOMMAND );
			State = 57;
			Match(THEN);
			State = 60;
			ErrorHandler.Sync(this);
			_alt = 1;
			do {
				switch (_alt) {
				case 1:
					{
					State = 60;
					ErrorHandler.Sync(this);
					switch (TokenStream.LA(1)) {
					case COMMAND:
						{
						State = 58;
						simplecommand();
						}
						break;
					case CONDITIONCOMMAND:
						{
						State = 59;
						conditioncommand();
						}
						break;
					default:
						throw new NoViableAltException(this);
					}
					}
					break;
				default:
					throw new NoViableAltException(this);
				}
				State = 62;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,7,Context);
			} while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER );
			State = 71;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,10,Context) ) {
			case 1:
				{
				State = 64;
				Match(ELSE);
				State = 67;
				ErrorHandler.Sync(this);
				_alt = 1;
				do {
					switch (_alt) {
					case 1:
						{
						State = 67;
						ErrorHandler.Sync(this);
						switch (TokenStream.LA(1)) {
						case COMMAND:
							{
							State = 65;
							simplecommand();
							}
							break;
						case CONDITIONCOMMAND:
							{
							State = 66;
							conditioncommand();
							}
							break;
						default:
							throw new NoViableAltException(this);
						}
						}
						break;
					default:
						throw new NoViableAltException(this);
					}
					State = 69;
					ErrorHandler.Sync(this);
					_alt = Interpreter.AdaptivePredict(TokenStream,9,Context);
				} while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER );
				}
				break;
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	private static int[] _serializedATN = {
		4,1,14,74,2,0,7,0,2,1,7,1,2,2,7,2,2,3,7,3,2,4,7,4,2,5,7,5,2,6,7,6,2,7,
		7,7,1,0,1,0,1,0,1,0,1,0,1,1,1,1,4,1,24,8,1,11,1,12,1,25,1,2,1,2,1,2,1,
		2,1,3,1,3,4,3,34,8,3,11,3,12,3,35,1,4,1,4,1,4,1,5,1,5,4,5,43,8,5,11,5,
		12,5,44,1,6,1,6,1,6,1,7,1,7,1,7,1,7,4,7,54,8,7,11,7,12,7,55,1,7,1,7,1,
		7,4,7,61,8,7,11,7,12,7,62,1,7,1,7,1,7,4,7,68,8,7,11,7,12,7,69,3,7,72,8,
		7,1,7,0,0,8,0,2,4,6,8,10,12,14,0,0,76,0,16,1,0,0,0,2,21,1,0,0,0,4,27,1,
		0,0,0,6,33,1,0,0,0,8,37,1,0,0,0,10,42,1,0,0,0,12,46,1,0,0,0,14,49,1,0,
		0,0,16,17,5,3,0,0,17,18,3,2,1,0,18,19,5,4,0,0,19,20,5,0,0,1,20,1,1,0,0,
		0,21,23,5,5,0,0,22,24,3,4,2,0,23,22,1,0,0,0,24,25,1,0,0,0,25,23,1,0,0,
		0,25,26,1,0,0,0,26,3,1,0,0,0,27,28,5,6,0,0,28,29,5,2,0,0,29,30,3,6,3,0,
		30,5,1,0,0,0,31,32,5,6,0,0,32,34,3,8,4,0,33,31,1,0,0,0,34,35,1,0,0,0,35,
		33,1,0,0,0,35,36,1,0,0,0,36,7,1,0,0,0,37,38,5,1,0,0,38,39,3,10,5,0,39,
		9,1,0,0,0,40,43,3,12,6,0,41,43,3,14,7,0,42,40,1,0,0,0,42,41,1,0,0,0,43,
		44,1,0,0,0,44,42,1,0,0,0,44,45,1,0,0,0,45,11,1,0,0,0,46,47,5,7,0,0,47,
		48,5,8,0,0,48,13,1,0,0,0,49,50,5,9,0,0,50,53,5,10,0,0,51,54,3,12,6,0,52,
		54,3,14,7,0,53,51,1,0,0,0,53,52,1,0,0,0,54,55,1,0,0,0,55,53,1,0,0,0,55,
		56,1,0,0,0,56,57,1,0,0,0,57,60,5,11,0,0,58,61,3,12,6,0,59,61,3,14,7,0,
		60,58,1,0,0,0,60,59,1,0,0,0,61,62,1,0,0,0,62,60,1,0,0,0,62,63,1,0,0,0,
		63,71,1,0,0,0,64,67,5,12,0,0,65,68,3,12,6,0,66,68,3,14,7,0,67,65,1,0,0,
		0,67,66,1,0,0,0,68,69,1,0,0,0,69,67,1,0,0,0,69,70,1,0,0,0,70,72,1,0,0,
		0,71,64,1,0,0,0,71,72,1,0,0,0,72,15,1,0,0,0,11,25,35,42,44,53,55,60,62,
		67,69,71
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
