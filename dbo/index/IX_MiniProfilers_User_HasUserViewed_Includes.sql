﻿create nonclustered index IX_MiniProfilers_User_HasUserViewed_Includes on MiniProfilers ([User], HasUserViewed) include (Id, [Started])