 




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Linq.Expressions;
using System.Collections;
using System.ComponentModel;
using System.Data.Common;
using System.Data.SqlClient;
using System.Numerics;

 namespace   MneData{
 
   public   abstract class   MneDataSettings{
      
	     public  static  string CnnString{
		    get { 
			    return  @"Data Source=dbserver;Initial Catalog=mainaer;User ID=sa;Password=P@ssword" ;
			}
		 }
          
   }
 
	  public  class  MneArticle{
	  [Flags]
	  public  enum  MneArticleColumns:ulong {
	       None=0,
		   				     CityId=0x1,
				
	     				     NodeId=0x2,
				
	     				     NodeName=0x4,
				
	     				     Inputer=0x8,
				
	     				     CreateTime=0x10,
				
	     				     Editor=0x20,
				
	     				     UpdateTime=0x40,
				
	     				     Hits=0x80,
				
	     				     DayHits=0x100,
				
	     				     WeekHits=0x200,
				
	     				     MonthHits=0x400,
				
	     				     LastHitTime=0x800,
				
	     				     Status=0x1000,
				
	     				     ID=0x2000,
				
	     				     Title=0x4000,
				
	     				     PinyinTitle=0x8000,
				
	     				     TitleHashKey=0x10000,
				
	     				     TitleIntact=0x20000,
				
	     				     Subheading=0x40000,
				
	     				     Author=0x80000,
				
	     				     CopyFrom=0x100000,
				
	     				     Keyword=0x200000,
				
	     				     Intro=0x400000,
				
	     				     Content=0x800000,
				
	     				     Stars=0x1000000,
				
	     				     PreFix=0x2000000,
				
	     				      DefaultPicUrl=0x4000000

				
	     	  }

	  const  string  __TableName=@"MneArticle";
	  static  readonly  Dictionary<MneArticleColumns,string>  __TableCols;
	  static   MneArticle(){
	         __TableCols=new Dictionary<MneArticleColumns,String>(27);
					         __TableCols.Add(MneArticleColumns.CityId,"CityId");
		    		         __TableCols.Add(MneArticleColumns.NodeId,"NodeId");
		    		         __TableCols.Add(MneArticleColumns.NodeName,"NodeName");
		    		         __TableCols.Add(MneArticleColumns.Inputer,"Inputer");
		    		         __TableCols.Add(MneArticleColumns.CreateTime,"CreateTime");
		    		         __TableCols.Add(MneArticleColumns.Editor,"Editor");
		    		         __TableCols.Add(MneArticleColumns.UpdateTime,"UpdateTime");
		    		         __TableCols.Add(MneArticleColumns.Hits,"Hits");
		    		         __TableCols.Add(MneArticleColumns.DayHits,"DayHits");
		    		         __TableCols.Add(MneArticleColumns.WeekHits,"WeekHits");
		    		         __TableCols.Add(MneArticleColumns.MonthHits,"MonthHits");
		    		         __TableCols.Add(MneArticleColumns.LastHitTime,"LastHitTime");
		    		         __TableCols.Add(MneArticleColumns.Status,"Status");
		    		         __TableCols.Add(MneArticleColumns.ID,"ID");
		    		         __TableCols.Add(MneArticleColumns.Title,"Title");
		    		         __TableCols.Add(MneArticleColumns.PinyinTitle,"PinyinTitle");
		    		         __TableCols.Add(MneArticleColumns.TitleHashKey,"TitleHashKey");
		    		         __TableCols.Add(MneArticleColumns.TitleIntact,"TitleIntact");
		    		         __TableCols.Add(MneArticleColumns.Subheading,"Subheading");
		    		         __TableCols.Add(MneArticleColumns.Author,"Author");
		    		         __TableCols.Add(MneArticleColumns.CopyFrom,"CopyFrom");
		    		         __TableCols.Add(MneArticleColumns.Keyword,"Keyword");
		    		         __TableCols.Add(MneArticleColumns.Intro,"Intro");
		    		         __TableCols.Add(MneArticleColumns.Content,"Content");
		    		         __TableCols.Add(MneArticleColumns.Stars,"Stars");
		    		         __TableCols.Add(MneArticleColumns.PreFix,"PreFix");
		    		         __TableCols.Add(MneArticleColumns.DefaultPicUrl,"DefaultPicUrl");
		    	  }
	  public   void     Add(){
	    
			     
			  
	  }
	  public   static  MneArticle   CreateMneArticleFromDataRecord(IDataRecord dr){
	     MneArticle  ent=new MneArticle();
		 		      			       ent.CityId=  dr.IsDBNull(dr.GetOrdinal("CityId")) ?default(int):(int)dr["CityId"];
			    
		 		      			       ent.NodeId=  dr.IsDBNull(dr.GetOrdinal("NodeId")) ?default(int):(int)dr["NodeId"];
			    
		 		      			       ent.NodeName=  dr.IsDBNull(dr.GetOrdinal("NodeName")) ?string.Empty:(string)dr["NodeName"];
			   
		 		      			       ent.Inputer=  dr.IsDBNull(dr.GetOrdinal("Inputer")) ?string.Empty:(string)dr["Inputer"];
			   
		 		      			       ent.CreateTime=  dr.IsDBNull(dr.GetOrdinal("CreateTime")) ?default(DateTime):(DateTime)dr["CreateTime"];
			    
		 		      			       ent.Editor=  dr.IsDBNull(dr.GetOrdinal("Editor")) ?string.Empty:(string)dr["Editor"];
			   
		 		      			       ent.UpdateTime=  dr.IsDBNull(dr.GetOrdinal("UpdateTime")) ?default(DateTime):(DateTime)dr["UpdateTime"];
			    
		 		      			       ent.Hits=  dr.IsDBNull(dr.GetOrdinal("Hits")) ?default(int):(int)dr["Hits"];
			    
		 		      			       ent.DayHits=  dr.IsDBNull(dr.GetOrdinal("DayHits")) ?default(int):(int)dr["DayHits"];
			    
		 		      			       ent.WeekHits=  dr.IsDBNull(dr.GetOrdinal("WeekHits")) ?default(int):(int)dr["WeekHits"];
			    
		 		      			       ent.MonthHits=  dr.IsDBNull(dr.GetOrdinal("MonthHits")) ?default(int):(int)dr["MonthHits"];
			    
		 		      			       ent.LastHitTime=  dr.IsDBNull(dr.GetOrdinal("LastHitTime")) ?default(DateTime):(DateTime)dr["LastHitTime"];
			    
		 		      			       ent.Status=  dr.IsDBNull(dr.GetOrdinal("Status")) ?default(int):(int)dr["Status"];
			    
		 		      			       ent.ID=  dr.IsDBNull(dr.GetOrdinal("ID")) ?default(int):(int)dr["ID"];
			    
		 		      			       ent.Title=  dr.IsDBNull(dr.GetOrdinal("Title")) ?string.Empty:(string)dr["Title"];
			   
		 		      			       ent.PinyinTitle=  dr.IsDBNull(dr.GetOrdinal("PinyinTitle")) ?string.Empty:(string)dr["PinyinTitle"];
			   
		 		      			       ent.TitleHashKey=  dr.IsDBNull(dr.GetOrdinal("TitleHashKey")) ?default(decimal):(decimal)dr["TitleHashKey"];
			    
		 		      			       ent.TitleIntact=  dr.IsDBNull(dr.GetOrdinal("TitleIntact")) ?string.Empty:(string)dr["TitleIntact"];
			   
		 		      			       ent.Subheading=  dr.IsDBNull(dr.GetOrdinal("Subheading")) ?string.Empty:(string)dr["Subheading"];
			   
		 		      			       ent.Author=  dr.IsDBNull(dr.GetOrdinal("Author")) ?string.Empty:(string)dr["Author"];
			   
		 		      			       ent.CopyFrom=  dr.IsDBNull(dr.GetOrdinal("CopyFrom")) ?string.Empty:(string)dr["CopyFrom"];
			   
		 		      			       ent.Keyword=  dr.IsDBNull(dr.GetOrdinal("Keyword")) ?string.Empty:(string)dr["Keyword"];
			   
		 		      			       ent.Intro=  dr.IsDBNull(dr.GetOrdinal("Intro")) ?string.Empty:(string)dr["Intro"];
			   
		 		      			       ent.Content=  dr.IsDBNull(dr.GetOrdinal("Content")) ?string.Empty:(string)dr["Content"];
			   
		 		      			       ent.Stars=  dr.IsDBNull(dr.GetOrdinal("Stars")) ?string.Empty:(string)dr["Stars"];
			   
		 		      			       ent.PreFix=  dr.IsDBNull(dr.GetOrdinal("PreFix")) ?string.Empty:(string)dr["PreFix"];
			   
		 		      			       ent.DefaultPicUrl=  dr.IsDBNull(dr.GetOrdinal("DefaultPicUrl")) ?string.Empty:(string)dr["DefaultPicUrl"];
			   
		 

		 return   ent ;


	  }
	  		   /// <summary>
          /// 
          /// </summary>
		   public   int   CityId{ get ;set ;}

		 
				   /// <summary>
          /// 
          /// </summary>
		   public   int   NodeId{ get ;set ;}

		 
				   /// <summary>
          /// 
          /// </summary>
		   public   string   NodeName{ get ;set ;}

		 
				   /// <summary>
          /// 
          /// </summary>
		   public   string   Inputer{ get ;set ;}

		 
				   /// <summary>
          /// 
          /// </summary>
		   public   DateTime   CreateTime{ get ;set ;}

		 
				   /// <summary>
          /// 
          /// </summary>
		   public   string   Editor{ get ;set ;}

		 
				   /// <summary>
          /// 
          /// </summary>
		   public   DateTime   UpdateTime{ get ;set ;}

		 
				   /// <summary>
          /// 
          /// </summary>
		   public   int   Hits{ get ;set ;}

		 
				   /// <summary>
          /// 
          /// </summary>
		   public   int   DayHits{ get ;set ;}

		 
				   /// <summary>
          /// 
          /// </summary>
		   public   int   WeekHits{ get ;set ;}

		 
				   /// <summary>
          /// 
          /// </summary>
		   public   int   MonthHits{ get ;set ;}

		 
				   /// <summary>
          /// 
          /// </summary>
		   public   DateTime   LastHitTime{ get ;set ;}

		 
				   /// <summary>
          /// 
          /// </summary>
		   public   int   Status{ get ;set ;}

		 
				   /// <summary>
          /// 文章ID
          /// </summary>
		   public   int   ID{ get ;set ;}

		 
				   /// <summary>
          /// 
          /// </summary>
		   public   string   Title{ get ;set ;}

		 
				   /// <summary>
          /// 
          /// </summary>
		   public   string   PinyinTitle{ get ;set ;}

		 
				   /// <summary>
          /// 
          /// </summary>
		   public   decimal   TitleHashKey{ get ;set ;}

		 
				   /// <summary>
          /// 完整标题
          /// </summary>
		   public   string   TitleIntact{ get ;set ;}

		 
				   /// <summary>
          /// 副标题
          /// </summary>
		   public   string   Subheading{ get ;set ;}

		 
				   /// <summary>
          /// 作者
          /// </summary>
		   public   string   Author{ get ;set ;}

		 
				   /// <summary>
          /// 来源
          /// </summary>
		   public   string   CopyFrom{ get ;set ;}

		 
				   /// <summary>
          /// 关键字
          /// </summary>
		   public   string   Keyword{ get ;set ;}

		 
				   /// <summary>
          /// 简介
          /// </summary>
		   public   string   Intro{ get ;set ;}

		 
				   /// <summary>
          /// 内容
          /// </summary>
		   public   string   Content{ get ;set ;}

		 
				   /// <summary>
          /// 状态
          /// </summary>
		   public   string   Stars{ get ;set ;}

		 
				   /// <summary>
          /// 
          /// </summary>
		   public   string   PreFix{ get ;set ;}

		 
				   /// <summary>
          /// 
          /// </summary>
		   public   string   DefaultPicUrl{ get ;set ;}

		 
		
	  }
    	  public  class  MneUsers{
	  [Flags]
	  public  enum  MneUsersColumns:ulong {
	       None=0,
		   				     MneID=0x1,
				
	     				     UserID=0x2,
				
	     				     UserName=0x4,
				
	     				     UserPassword=0x8,
				
	     				     LoginTimes=0x10,
				
	     				     LastLoginIP=0x20,
				
	     				     LastLoginTime=0x40,
				
	     				     IsLock=0x80,
				
	     				     Hash=0x100,
				
	     				     LoginErrorTimes=0x200,
				
	     				     UserType=0x400,
				
	     				     UserRootId=0x800,
				
	     				     EMail=0x1000,
				
	     				     NickName=0x2000,
				
	     				     RegTime=0x4000,
				
	     				     TuName=0x8000,
				
	     				     TuPhone=0x10000,
				
	     				     TuCardName=0x20000,
				
	     				     TuCardNum=0x40000,
				
	     				     TuValidated=0x80000,
				
	     				     BigImageUrl=0x100000,
				
	     				     MidImageUrl=0x200000,
				
	     				     SmlImageUrl=0x400000,
				
	     				     Question=0x800000,
				
	     				     Answer=0x1000000,
				
	     				     TUCardImage=0x2000000,
				
	     				     BusinessCardImage=0x4000000,
				
	     				     BusinessCardMemo=0x8000000,
				
	     				      PortraitImage=0x10000000

				
	     	  }

	  const  string  __TableName=@"MneUsers";
	  static  readonly  Dictionary<MneUsersColumns,string>  __TableCols;
	  static   MneUsers(){
	         __TableCols=new Dictionary<MneUsersColumns,String>(29);
					         __TableCols.Add(MneUsersColumns.MneID,"MneID");
		    		         __TableCols.Add(MneUsersColumns.UserID,"UserID");
		    		         __TableCols.Add(MneUsersColumns.UserName,"UserName");
		    		         __TableCols.Add(MneUsersColumns.UserPassword,"UserPassword");
		    		         __TableCols.Add(MneUsersColumns.LoginTimes,"LoginTimes");
		    		         __TableCols.Add(MneUsersColumns.LastLoginIP,"LastLoginIP");
		    		         __TableCols.Add(MneUsersColumns.LastLoginTime,"LastLoginTime");
		    		         __TableCols.Add(MneUsersColumns.IsLock,"IsLock");
		    		         __TableCols.Add(MneUsersColumns.Hash,"Hash");
		    		         __TableCols.Add(MneUsersColumns.LoginErrorTimes,"LoginErrorTimes");
		    		         __TableCols.Add(MneUsersColumns.UserType,"UserType");
		    		         __TableCols.Add(MneUsersColumns.UserRootId,"UserRootId");
		    		         __TableCols.Add(MneUsersColumns.EMail,"EMail");
		    		         __TableCols.Add(MneUsersColumns.NickName,"NickName");
		    		         __TableCols.Add(MneUsersColumns.RegTime,"RegTime");
		    		         __TableCols.Add(MneUsersColumns.TuName,"TuName");
		    		         __TableCols.Add(MneUsersColumns.TuPhone,"TuPhone");
		    		         __TableCols.Add(MneUsersColumns.TuCardName,"TuCardName");
		    		         __TableCols.Add(MneUsersColumns.TuCardNum,"TuCardNum");
		    		         __TableCols.Add(MneUsersColumns.TuValidated,"TuValidated");
		    		         __TableCols.Add(MneUsersColumns.BigImageUrl,"BigImageUrl");
		    		         __TableCols.Add(MneUsersColumns.MidImageUrl,"MidImageUrl");
		    		         __TableCols.Add(MneUsersColumns.SmlImageUrl,"SmlImageUrl");
		    		         __TableCols.Add(MneUsersColumns.Question,"Question");
		    		         __TableCols.Add(MneUsersColumns.Answer,"Answer");
		    		         __TableCols.Add(MneUsersColumns.TUCardImage,"TUCardImage");
		    		         __TableCols.Add(MneUsersColumns.BusinessCardImage,"BusinessCardImage");
		    		         __TableCols.Add(MneUsersColumns.BusinessCardMemo,"BusinessCardMemo");
		    		         __TableCols.Add(MneUsersColumns.PortraitImage,"PortraitImage");
		    	  }
	  public   void     Add(){
	    
			     
			  
	  }
	  public   static  MneUsers   CreateMneUsersFromDataRecord(IDataRecord dr){
	     MneUsers  ent=new MneUsers();
		 		      			       ent.MneID=  dr.IsDBNull(dr.GetOrdinal("MneID")) ?default(Guid):(Guid)dr["MneID"];
			    
		 		      			       ent.UserID=  dr.IsDBNull(dr.GetOrdinal("UserID")) ?default(int):(int)dr["UserID"];
			    
		 		      			       ent.UserName=  dr.IsDBNull(dr.GetOrdinal("UserName")) ?string.Empty:(string)dr["UserName"];
			   
		 		      			       ent.UserPassword=  dr.IsDBNull(dr.GetOrdinal("UserPassword")) ?string.Empty:(string)dr["UserPassword"];
			   
		 		      			       ent.LoginTimes=  dr.IsDBNull(dr.GetOrdinal("LoginTimes")) ?default(int):(int)dr["LoginTimes"];
			    
		 		      			       ent.LastLoginIP=  dr.IsDBNull(dr.GetOrdinal("LastLoginIP")) ?string.Empty:(string)dr["LastLoginIP"];
			   
		 		      			       ent.LastLoginTime=  dr.IsDBNull(dr.GetOrdinal("LastLoginTime")) ?default(DateTime):(DateTime)dr["LastLoginTime"];
			    
		 		      			       ent.IsLock=  dr.IsDBNull(dr.GetOrdinal("IsLock")) ?default(bool):(bool)dr["IsLock"];
			    
		 		      			       ent.Hash=  dr.IsDBNull(dr.GetOrdinal("Hash")) ?string.Empty:(string)dr["Hash"];
			   
		 		      			       ent.LoginErrorTimes=  dr.IsDBNull(dr.GetOrdinal("LoginErrorTimes")) ?default(int):(int)dr["LoginErrorTimes"];
			    
		 		      			       ent.UserType=  dr.IsDBNull(dr.GetOrdinal("UserType")) ?default(int):(int)dr["UserType"];
			    
		 		      			       ent.UserRootId=  dr.IsDBNull(dr.GetOrdinal("UserRootId")) ?default(int):(int)dr["UserRootId"];
			    
		 		      			       ent.EMail=  dr.IsDBNull(dr.GetOrdinal("EMail")) ?string.Empty:(string)dr["EMail"];
			   
		 		      			       ent.NickName=  dr.IsDBNull(dr.GetOrdinal("NickName")) ?string.Empty:(string)dr["NickName"];
			   
		 		      			       ent.RegTime=  dr.IsDBNull(dr.GetOrdinal("RegTime")) ?default(DateTime):(DateTime)dr["RegTime"];
			    
		 		      			       ent.TuName=  dr.IsDBNull(dr.GetOrdinal("TuName")) ?string.Empty:(string)dr["TuName"];
			   
		 		      			       ent.TuPhone=  dr.IsDBNull(dr.GetOrdinal("TuPhone")) ?string.Empty:(string)dr["TuPhone"];
			   
		 		      			       ent.TuCardName=  dr.IsDBNull(dr.GetOrdinal("TuCardName")) ?string.Empty:(string)dr["TuCardName"];
			   
		 		      			       ent.TuCardNum=  dr.IsDBNull(dr.GetOrdinal("TuCardNum")) ?string.Empty:(string)dr["TuCardNum"];
			   
		 		      			       ent.TuValidated=  dr.IsDBNull(dr.GetOrdinal("TuValidated")) ?default(bool):(bool)dr["TuValidated"];
			    
		 		      			       ent.BigImageUrl=  dr.IsDBNull(dr.GetOrdinal("BigImageUrl")) ?string.Empty:(string)dr["BigImageUrl"];
			   
		 		      			       ent.MidImageUrl=  dr.IsDBNull(dr.GetOrdinal("MidImageUrl")) ?string.Empty:(string)dr["MidImageUrl"];
			   
		 		      			       ent.SmlImageUrl=  dr.IsDBNull(dr.GetOrdinal("SmlImageUrl")) ?string.Empty:(string)dr["SmlImageUrl"];
			   
		 		      			       ent.Question=  dr.IsDBNull(dr.GetOrdinal("Question")) ?string.Empty:(string)dr["Question"];
			   
		 		      			       ent.Answer=  dr.IsDBNull(dr.GetOrdinal("Answer")) ?string.Empty:(string)dr["Answer"];
			   
		 		      			       ent.TUCardImage=  dr.IsDBNull(dr.GetOrdinal("TUCardImage")) ?string.Empty:(string)dr["TUCardImage"];
			   
		 		      			       ent.BusinessCardImage=  dr.IsDBNull(dr.GetOrdinal("BusinessCardImage")) ?string.Empty:(string)dr["BusinessCardImage"];
			   
		 		      			       ent.BusinessCardMemo=  dr.IsDBNull(dr.GetOrdinal("BusinessCardMemo")) ?string.Empty:(string)dr["BusinessCardMemo"];
			   
		 		      			       ent.PortraitImage=  dr.IsDBNull(dr.GetOrdinal("PortraitImage")) ?string.Empty:(string)dr["PortraitImage"];
			   
		 

		 return   ent ;


	  }
	  		   /// <summary>
          /// 
          /// </summary>
		   public   Guid   MneID{ get ;set ;}

		 
				   /// <summary>
          /// 
          /// </summary>
		   public   int   UserID{ get ;set ;}

		 
				   /// <summary>
          /// 
          /// </summary>
		   public   string   UserName{ get ;set ;}

		 
				   /// <summary>
          /// MD5 加密过的密码
          /// </summary>
		   public   string   UserPassword{ get ;set ;}

		 
				   /// <summary>
          /// 
          /// </summary>
		   public   int   LoginTimes{ get ;set ;}

		 
				   /// <summary>
          /// 
          /// </summary>
		   public   string   LastLoginIP{ get ;set ;}

		 
				   /// <summary>
          /// 
          /// </summary>
		   public   DateTime   LastLoginTime{ get ;set ;}

		 
				   /// <summary>
          /// 
          /// </summary>
		   public   bool   IsLock{ get ;set ;}

		 
				   /// <summary>
          /// hash  算法  
          /// </summary>
		   public   string   Hash{ get ;set ;}

		 
				   /// <summary>
          /// 
          /// </summary>
		   public   int   LoginErrorTimes{ get ;set ;}

		 
				   /// <summary>
          /// 0：普通用户；1：经纪人用户；2：管理员
          /// </summary>
		   public   int   UserType{ get ;set ;}

		 
				   /// <summary>
          /// 用户注册的城市，仅用于经纪人
          /// </summary>
		   public   int   UserRootId{ get ;set ;}

		 
				   /// <summary>
          /// 
          /// </summary>
		   public   string   EMail{ get ;set ;}

		 
				   /// <summary>
          /// 昵称
          /// </summary>
		   public   string   NickName{ get ;set ;}

		 
				   /// <summary>
          /// 注册时间
          /// </summary>
		   public   DateTime   RegTime{ get ;set ;}

		 
				   /// <summary>
          /// 实名
          /// </summary>
		   public   string   TuName{ get ;set ;}

		 
				   /// <summary>
          /// 实名电话
          /// </summary>
		   public   string   TuPhone{ get ;set ;}

		 
				   /// <summary>
          /// 证件类型
          /// </summary>
		   public   string   TuCardName{ get ;set ;}

		 
				   /// <summary>
          /// 证件号码
          /// </summary>
		   public   string   TuCardNum{ get ;set ;}

		 
				   /// <summary>
          /// 是否经过认证
          /// </summary>
		   public   bool   TuValidated{ get ;set ;}

		 
				   /// <summary>
          /// 大头像
          /// </summary>
		   public   string   BigImageUrl{ get ;set ;}

		 
				   /// <summary>
          /// 中等的图像
          /// </summary>
		   public   string   MidImageUrl{ get ;set ;}

		 
				   /// <summary>
          /// 小图像
          /// </summary>
		   public   string   SmlImageUrl{ get ;set ;}

		 
				   /// <summary>
          /// 安全问题（加密）
          /// </summary>
		   public   string   Question{ get ;set ;}

		 
				   /// <summary>
          /// 安全答案
          /// </summary>
		   public   string   Answer{ get ;set ;}

		 
				   /// <summary>
          /// 
          /// </summary>
		   public   string   TUCardImage{ get ;set ;}

		 
				   /// <summary>
          /// 
          /// </summary>
		   public   string   BusinessCardImage{ get ;set ;}

		 
				   /// <summary>
          /// 
          /// </summary>
		   public   string   BusinessCardMemo{ get ;set ;}

		 
				   /// <summary>
          /// 
          /// </summary>
		   public   string   PortraitImage{ get ;set ;}

		 
		
	  }
    	  public  class  MneNodes{
	  [Flags]
	  public  enum  MneNodesColumns:ulong {
	       None=0,
		   				     NodeID=0x1,
				
	     				     NodeName=0x2,
				
	     				     NodeDir=0x4,
				
	     				     OrderID=0x8,
				
	     				     NodeType=0x10,
				
	     				     Tips=0x20,
				
	     				     RootID=0x40,
				
	     				     ParentID=0x80,
				
	     				     Description=0x100,
				
	     				     NodePicUrl=0x200,
				
	     				     Meta_Title=0x400,
				
	     				     Meta_Keywords=0x800,
				
	     				     Meta_Description=0x1000,
				
	     				     Creater=0x2000,
				
	     				     Jd=0x4000,
				
	     				     Wd=0x8000,
				
	     				      ModelID=0x10000

				
	     	  }

	  const  string  __TableName=@"MneNodes";
	  static  readonly  Dictionary<MneNodesColumns,string>  __TableCols;
	  static   MneNodes(){
	         __TableCols=new Dictionary<MneNodesColumns,String>(17);
					         __TableCols.Add(MneNodesColumns.NodeID,"NodeID");
		    		         __TableCols.Add(MneNodesColumns.NodeName,"NodeName");
		    		         __TableCols.Add(MneNodesColumns.NodeDir,"NodeDir");
		    		         __TableCols.Add(MneNodesColumns.OrderID,"OrderID");
		    		         __TableCols.Add(MneNodesColumns.NodeType,"NodeType");
		    		         __TableCols.Add(MneNodesColumns.Tips,"Tips");
		    		         __TableCols.Add(MneNodesColumns.RootID,"RootID");
		    		         __TableCols.Add(MneNodesColumns.ParentID,"ParentID");
		    		         __TableCols.Add(MneNodesColumns.Description,"Description");
		    		         __TableCols.Add(MneNodesColumns.NodePicUrl,"NodePicUrl");
		    		         __TableCols.Add(MneNodesColumns.Meta_Title,"Meta_Title");
		    		         __TableCols.Add(MneNodesColumns.Meta_Keywords,"Meta_Keywords");
		    		         __TableCols.Add(MneNodesColumns.Meta_Description,"Meta_Description");
		    		         __TableCols.Add(MneNodesColumns.Creater,"Creater");
		    		         __TableCols.Add(MneNodesColumns.Jd,"Jd");
		    		         __TableCols.Add(MneNodesColumns.Wd,"Wd");
		    		         __TableCols.Add(MneNodesColumns.ModelID,"ModelID");
		    	  }
	  public   void     Add(){
	    
			     
			  
	  }
	  public   static  MneNodes   CreateMneNodesFromDataRecord(IDataRecord dr){
	     MneNodes  ent=new MneNodes();
		 		      			       ent.NodeID=  dr.IsDBNull(dr.GetOrdinal("NodeID")) ?default(int):(int)dr["NodeID"];
			    
		 		      			       ent.NodeName=  dr.IsDBNull(dr.GetOrdinal("NodeName")) ?string.Empty:(string)dr["NodeName"];
			   
		 		      			       ent.NodeDir=  dr.IsDBNull(dr.GetOrdinal("NodeDir")) ?string.Empty:(string)dr["NodeDir"];
			   
		 		      			       ent.OrderID=  dr.IsDBNull(dr.GetOrdinal("OrderID")) ?default(int):(int)dr["OrderID"];
			    
		 		      			       ent.NodeType=  dr.IsDBNull(dr.GetOrdinal("NodeType")) ?default(int):(int)dr["NodeType"];
			    
		 		      			       ent.Tips=  dr.IsDBNull(dr.GetOrdinal("Tips")) ?string.Empty:(string)dr["Tips"];
			   
		 		      			       ent.RootID=  dr.IsDBNull(dr.GetOrdinal("RootID")) ?default(int):(int)dr["RootID"];
			    
		 		      			       ent.ParentID=  dr.IsDBNull(dr.GetOrdinal("ParentID")) ?default(int):(int)dr["ParentID"];
			    
		 		      			       ent.Description=  dr.IsDBNull(dr.GetOrdinal("Description")) ?string.Empty:(string)dr["Description"];
			   
		 		      			       ent.NodePicUrl=  dr.IsDBNull(dr.GetOrdinal("NodePicUrl")) ?string.Empty:(string)dr["NodePicUrl"];
			   
		 		      			       ent.Meta_Title=  dr.IsDBNull(dr.GetOrdinal("Meta_Title")) ?string.Empty:(string)dr["Meta_Title"];
			   
		 		      			       ent.Meta_Keywords=  dr.IsDBNull(dr.GetOrdinal("Meta_Keywords")) ?string.Empty:(string)dr["Meta_Keywords"];
			   
		 		      			       ent.Meta_Description=  dr.IsDBNull(dr.GetOrdinal("Meta_Description")) ?string.Empty:(string)dr["Meta_Description"];
			   
		 		      			       ent.Creater=  dr.IsDBNull(dr.GetOrdinal("Creater")) ?string.Empty:(string)dr["Creater"];
			   
		 		      			       ent.Jd=  dr.IsDBNull(dr.GetOrdinal("Jd")) ?default(decimal):(decimal)dr["Jd"];
			    
		 		      			       ent.Wd=  dr.IsDBNull(dr.GetOrdinal("Wd")) ?default(decimal):(decimal)dr["Wd"];
			    
		 		      			       ent.ModelID=  dr.IsDBNull(dr.GetOrdinal("ModelID")) ?default(int):(int)dr["ModelID"];
			    
		 

		 return   ent ;


	  }
	  		   /// <summary>
          /// 
          /// </summary>
		   public   int   NodeID{ get ;set ;}

		 
				   /// <summary>
          /// 节点名称
          /// </summary>
		   public   string   NodeName{ get ;set ;}

		 
				   /// <summary>
          /// 节点目录名称
          /// </summary>
		   public   string   NodeDir{ get ;set ;}

		 
				   /// <summary>
          /// 排序ID 
          /// </summary>
		   public   int   OrderID{ get ;set ;}

		 
				   /// <summary>
          /// 节点类型：1---单节点；2：目录节点
          /// </summary>
		   public   int   NodeType{ get ;set ;}

		 
				   /// <summary>
          /// 提示
          /// </summary>
		   public   string   Tips{ get ;set ;}

		 
				   /// <summary>
          /// 所属城市ID 
          /// </summary>
		   public   int   RootID{ get ;set ;}

		 
				   /// <summary>
          /// 上级节点ID 
          /// </summary>
		   public   int   ParentID{ get ;set ;}

		 
				   /// <summary>
          /// 节点说明
          /// </summary>
		   public   string   Description{ get ;set ;}

		 
				   /// <summary>
          /// 节点的默认图片地址
          /// </summary>
		   public   string   NodePicUrl{ get ;set ;}

		 
				   /// <summary>
          /// 目录节点的首页标题
          /// </summary>
		   public   string   Meta_Title{ get ;set ;}

		 
				   /// <summary>
          /// SEO 的关键字
          /// </summary>
		   public   string   Meta_Keywords{ get ;set ;}

		 
				   /// <summary>
          /// SEO的描述
          /// </summary>
		   public   string   Meta_Description{ get ;set ;}

		 
				   /// <summary>
          /// 创建人员用户名
          /// </summary>
		   public   string   Creater{ get ;set ;}

		 
				   /// <summary>
          /// 经度
          /// </summary>
		   public   decimal   Jd{ get ;set ;}

		 
				   /// <summary>
          /// 纬度
          /// </summary>
		   public   decimal   Wd{ get ;set ;}

		 
				   /// <summary>
          /// 内容模型：1 ----  文章； 5 -----楼盘
          /// </summary>
		   public   int   ModelID{ get ;set ;}

		 
		
	  }
    
	}
 