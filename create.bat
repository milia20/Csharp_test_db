sqlcmd -S lpc:WIN10\SQLEXPRESS -e -v FullScriptDir="$pwd" -i CreateDB.sql -b