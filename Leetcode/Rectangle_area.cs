public class Rect_Area {
    public int ComputeArea(int ax1, int ay1, int ax2, int ay2, int bx1, int by1, int bx2, int by2) {
        int areaA=(ax2-ax1)*(ay2-ay1);
        int areaB=(bx2-bx1)*(by2-by1);

        int leftX=Math.Max(ax1,bx1);
        int rightX=Math.Min(ax2,bx2);

        int bottomY=Math.Max(ay1,by1);
        int topY=Math.Min(ay2,by2);

        int w=rightX-leftX;
        int h=topY-bottomY;

        if(w<0 || h<0){
            return areaA+areaB;
        }
        else{
            return areaA+areaB-w*h;
        }
    }
}