grammar Game;
/*
 правила парсера
 */
game: GAMESTART initGame GAMEEND EOF;
initGame: INIT objectWithProperty+;
/*Здесь WORD - это название объекта*/
objectWithProperty: WORD PROPERTIES objectProperties;
/*Здесь WORD - это название свойства объекта*/
objectProperties: (WORD property)+;
property: INCLUDE chainOfCommands;
chainOfCommands: (simplecommand | conditioncommand)+;
simplecommand : COMMAND GAMECOMMANDS;
conditioncommand : CONDITIONCOMMAND 
                   IF (simplecommand | conditioncommand)+
                   THEN (simplecommand | conditioncommand)+
                   (ELSE (simplecommand | conditioncommand)+)?;

/*ДОПОЛНИТЬ ТУТ*/

/*
 правила лексера
 */
fragment LOWERCASE: [a-z];
fragment UPPERCASE: [A-Z];
fragment NUMBERS: [0-9];
INCLUDE : 'Include';
PROPERTIES : 'Properties';
GAMESTART: 'Start';
GAMEEND: 'End';
INIT: 'Init';
WORD: (LOWERCASE | UPPERCASE)+;
COMMAND : 'Command';
GAMECOMMANDS : ('Move' | 'Rotate' | 'CheckFuel' | 'BurnFuel' | 'Shoot');
CONDITIONCOMMAND : 'ConditionCommand';
IF : 'If';
THEN : 'Then';
ELSE : 'Else';
WHITESPACE: (' ' | '\t')+ -> skip;
NEWLINE   : ('\r'? '\n' | '\r')+;
