; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName "KeePass Password Safe"
#define MyAppVerName "KeePass Password Safe 2.00 Alpha"
#define MyAppPublisher "Dominik Reichl"
#define MyAppURL "http://keepass.info/"
#define MyAppExeName "KeePass.exe"
#define MyAppUrlName "KeePass.url"
#define MyAppBaseSetupExe "KeePass-2.00-Alpha-Setup"

[Setup]
AppName={#MyAppName}
AppVerName={#MyAppVerName}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName={pf}\{#MyAppName}
DefaultGroupName={#MyAppName}
AllowNoIcons=yes
LicenseFile=..\Docs\License_Install.txt
OutputBaseFilename={#MyAppBaseSetupExe}
Compression=lzma
SolidCompression=true
InternalCompressLevel=ultra

[Languages]
Name: english; MessagesFile: compiler:Default.isl
Name: brazilianportuguese; MessagesFile: compiler:Languages\BrazilianPortuguese.isl
Name: catalan; MessagesFile: compiler:Languages\Catalan.isl
Name: czech; MessagesFile: compiler:Languages\Czech.isl
Name: danish; MessagesFile: compiler:Languages\Danish.isl
Name: dutch; MessagesFile: compiler:Languages\Dutch.isl
Name: finnish; MessagesFile: compiler:Languages\Finnish.isl
Name: french; MessagesFile: compiler:Languages\French.isl
Name: german; MessagesFile: compiler:Languages\German.isl
Name: hungarian; MessagesFile: compiler:Languages\Hungarian.isl
Name: italian; MessagesFile: compiler:Languages\Italian.isl
Name: norwegian; MessagesFile: compiler:Languages\Norwegian.isl
Name: polish; MessagesFile: compiler:Languages\Polish.isl
Name: portuguese; MessagesFile: compiler:Languages\Portuguese.isl
Name: russian; MessagesFile: compiler:Languages\Russian.isl
Name: slovak; MessagesFile: compiler:Languages\Slovak.isl
Name: slovenian; MessagesFile: compiler:Languages\Slovenian.isl

[Tasks]
Name: desktopicon; Description: {cm:CreateDesktopIcon}; GroupDescription: {cm:AdditionalIcons}; Flags: unchecked
Name: quicklaunchicon; Description: {cm:CreateQuickLaunchIcon}; GroupDescription: {cm:AdditionalIcons}; Flags: unchecked

[Files]
Source: ..\Build\KeePass_Distrib\KeePass.exe; DestDir: {app}; Flags: ignoreversion
Source: ..\Build\KeePass_Distrib\License.txt; DestDir: {app}; Flags: ignoreversion
Source: ..\Build\KeePass_Distrib\XSL\KDB4_DetailsFull.xsl; DestDir: {app}\XSL; Components: XSL
Source: ..\Build\KeePass_Distrib\XSL\KDB4_DetailsLite.xsl; DestDir: {app}\XSL; Components: XSL
Source: ..\Build\KeePass_Distrib\XSL\KDB4_Styles.css; DestDir: {app}\XSL; Components: XSL
Source: ..\Build\KeePass_Distrib\XSL\KDB4_Tabular.xsl; DestDir: {app}\XSL; Components: XSL
Source: ..\Build\KeePass_Distrib\XSL\TableHeader.gif; DestDir: {app}\XSL; Components: XSL
Source: ..\Build\KeePass_Distrib\KeePass.config.xml; DestDir: {app}; Flags: onlyifdoesntexist
Source: ..\Build\KeePass_Distrib\KeePassLibC.dll; DestDir: {app}; Components: KDB3Support
Source: ..\Build\KeePass_Distrib\KeePassNtv.dll; DestDir: {app}; Components: NativeLib
Source: ..\Build\KeePass_Distrib\KeePass.chm; DestDir: {app}; Components: UserDoc
Source: ..\Build\KeePass_Distrib\ShInstUtil.exe; DestDir: {app}

[INI]
Filename: {app}\{#MyAppUrlName}; Section: InternetShortcut; Key: URL; String: {#MyAppURL}

[Icons]
Name: {group}\{#MyAppName}; Filename: {app}\{#MyAppExeName}
Name: {group}\{cm:ProgramOnTheWeb,{#MyAppName}}; Filename: {app}\{#MyAppUrlName}
Name: {group}\{cm:UninstallProgram,{#MyAppName}}; Filename: {uninstallexe}
Name: {userdesktop}\{#MyAppName}; Filename: {app}\{#MyAppExeName}; Tasks: desktopicon
Name: {userappdata}\Microsoft\Internet Explorer\Quick Launch\{#MyAppName}; Filename: {app}\{#MyAppExeName}; Tasks: quicklaunchicon

[Run]
Filename: {app}\{#MyAppExeName}; Description: {cm:LaunchProgram,{#MyAppName}}; Flags: nowait postinstall skipifsilent
Filename: {app}\ShInstUtil.exe; Parameters: ngen_install; Languages: ; Components: NGen; WorkingDir: {app}; Flags: skipifdoesntexist
Filename: {app}\KeePass.exe; Parameters: -RegisterFileExt; Components: FileAssoc

[UninstallDelete]
Type: files; Name: {app}\{#MyAppUrlName}

[Components]
Name: Core; Description: Core KeePass Application Files; Flags: fixed; Types: custom compact full; Languages: 
Name: UserDoc; Description: Help Manual; Types: custom full
Name: KDB3Support; Description: KDB3 Files Support (KeePass Classic); Types: custom full
Name: NativeLib; Description: Native Crypto Library (Fast Key Transformations); Types: custom full
Name: XSL; Description: XSL Stylesheets for KDB4 XML Files; Types: custom full
Name: NGen; Description: Generate Native Executable; Types: custom full; ExtraDiskSpaceRequired: 1048576
Name: FileAssoc; Description: Associate .KDB Files with KeePass; Types: custom full

[UninstallRun]
Filename: {app}\ShInstUtil.exe; Parameters: ngen_uninstall; Languages: ; Components: NGen; WorkingDir: {app}; Flags: skipifdoesntexist
Filename: {app}\KeePass.exe; Parameters: -UnregisterFileExt
