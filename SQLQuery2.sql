create view Menu_Gor as Select m.MenuAd,m.MenuNo,i.IcecekNo,i.IcecekAd,y.YiyecekNo,y.YiyecekAd
from Icecek as i
Join Menu as m on i.IcecekNo=m.IcecekNo
Join Yiyecek as y on m.YiyecekNo=y.YiyecekNo


