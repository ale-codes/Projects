
/**
 * © Gloria Gutierrez
 * Spring 2018
 * */

/***************************************************************************************************************
 * ************** This program allows the user to draw an oval and change its size  ****************************
 * *************************** by dragging the mouse across the screen******************************************
 * *************************************************************************************************************
 * */


import java.awt.*;
import java.awt.event.*;
import java.awt.geom.*;
import javax.swing.*;

public class DrawAndDragOval extends JPanel {

    private int x;
    private int y;
    private int width;
    private int height;
    private static JFrame frame = new JFrame("Dragged_Oval");
    private MouseDragged mouseDragged;
    private boolean draggedOval = false;
    private Point lastPos;



    public static void main(String[] args){
        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        frame.setSize(400, 400);
        frame.add(new DrawAndDragOval());
        frame.setVisible(true);
    }

    public DrawAndDragOval(){
        setBackground(Color.WHITE);
        mouseDragged = new MouseDragged();
        addMouseListener(mouseDragged);
        addMouseMotionListener(mouseDragged);
    }

    public boolean isInsideOval(Point point){
        return new Ellipse2D.Float(x, y, width, height).contains(point);
    }

    @Override
    public void paintComponent(Graphics g){
        super.paintComponent(g);
        Graphics2D g2 = (Graphics2D) g;
        g2.setColor(Color.blue);
        RenderingHints hints = new RenderingHints (RenderingHints.KEY_COLOR_RENDERING, RenderingHints.VALUE_COLOR_RENDER_DEFAULT);
        g2.setRenderingHints(hints);

        final float dash[] = {10.0f};
        final BasicStroke dashed =
                new BasicStroke(1.0f,
                        BasicStroke.CAP_BUTT,
                        BasicStroke.JOIN_MITER,
                        10.0f, dash,  0.0f);
        g2.setStroke(dashed);
        g2.fillOval(x, y, width, height);
    }

    private final class MouseDragged extends MouseAdapter {

        @Override
        public void mousePressed(MouseEvent m){
            lastPos = m.getPoint();
            draggedOval = isInsideOval(lastPos);
            if (!draggedOval){
                x = lastPos.x;
                y = lastPos.y;
                width = 0;
                height = 0;
            }
            repaint();
        }

        @Override
        public void mouseDragged(MouseEvent curPos) {
            int newX = curPos.getX() - lastPos.x;
            int newY = curPos.getY() - lastPos.y;

            if (draggedOval) {
                x += newX;
                y += newY;
            } else {
                width += newX;
                height += newY;
            }
            lastPos = curPos.getPoint();
            repaint();
        }

        @Override
        public void mouseReleased(MouseEvent m){
            lastPos = null;
            draggedOval = false;
            repaint();
        }
    }
}


























