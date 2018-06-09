
/**
 * © Gloria Gutierrez
 * Spring 2018
 * */

/***************************************************************************************************************
 * ****************** This program runs a GUI to order breakfast items in a hotel room *************************
 * ************************** (Action events listed in console during execution) *******************************
 * *************************************************************************************************************
 * */

import java.awt.*;
import java.awt.event.*;
import java.text.DecimalFormat;
import javax.swing.*;


public class BreakfastOrder extends JFrame {

    private JTextArea output = new JTextArea( 20, 20 );
    private JButton submit;
    private JCheckBox eggs, bacon, pancakes;
    double totalPrice = 0.00;
    double eggsPrice = 3.00;
    double baconPrice = 2.50;
    double cakesPrice = 2.00;

    public static void main(String[] args) {
        JFrame frame = new BreakfastOrder();
        frame.setVisible(true);
    }

    public BreakfastOrder() {
        setTitle("My Hotel Ordering System");
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        setSize(500, 500);

        //Checkboxes
        JPanel panel = new JPanel();
        panel.setLayout(new BoxLayout(panel, BoxLayout.Y_AXIS));
        eggs = new JCheckBox("Eggs (x2) ............................$3.00");
        eggs.addActionListener(new eggsChecked());
        panel.add(eggs);
        bacon = new JCheckBox("Bacon (2 Pieces)..............$2.50");
        bacon.addActionListener(new baconChecked());
        panel.add(bacon);
        pancakes = new JCheckBox("Pancakes (Stack of 3)....$2.00");
        pancakes.addActionListener(new cakesChecked());
        panel.add(pancakes);
        add(panel, BorderLayout.NORTH);

        //Output Area
        JPanel outputPanel = new JPanel();
        outputPanel.setLayout(new FlowLayout());
        outputPanel.add(output);//Adds JTextArea
        output.setLineWrap( true );
        output.setWrapStyleWord( true );
        String header = "Your order >> \n";
        output.setBackground(Color.lightGray);
        output.append(header);
        add(outputPanel, BorderLayout.CENTER);

        //'Submit' Button
        JPanel buttonPanel = new JPanel();
        buttonPanel.setLayout(new FlowLayout());
        submit = new JButton("Submit Order");
        submit.addActionListener(new buttonPressed());
        buttonPanel.add(submit);
        add(buttonPanel, BorderLayout.SOUTH);
        //pack();
    }

     private class eggsChecked implements ActionListener{
        public void actionPerformed (ActionEvent e){
            if (eggs.isSelected()){
                System.out.print("\n 'Eggs' was selected by 'eggsChecked' ActionListener/event ");
                output.append("\n ADD Eggs");
                totalPrice = totalPrice + eggsPrice;
            }
            else{
                System.out.print("\n   - Item 'Eggs' was removed by 'eggsChecked' ActionListener/event ");
                output.append("\n    - REMOVE Eggs");
                totalPrice = totalPrice - eggsPrice;
            }
        }
     }

     private class baconChecked implements ActionListener{
        public void actionPerformed(ActionEvent e){
            if (bacon.isSelected()){
                System.out.print("\n 'Bacon' was selected by 'baconChecked' ActionListener/event ");
                output.append("\n ADD Bacon");
                totalPrice = totalPrice + baconPrice;
            }
            else{
                System.out.print("\n   - Item 'Bacon' was removed by 'baconChecked' ActionListener/event ");
                output.append("\n    - REMOVE Bacon");
                totalPrice = totalPrice - baconPrice;
            }
        }
     }

     private class cakesChecked implements ActionListener{
        public void actionPerformed  (ActionEvent e){
            if (pancakes.isSelected()){
                System.out.print("\n 'Pancakes' was selected by 'cakesChecked' ActionListener/event ");
                output.append("\n ADD Pancakes");
                totalPrice = totalPrice + cakesPrice;
            }
            else{
                System.out.print("\n   - Item 'Pancakes' was removed by 'cakesChecked' ActionListener/event ");
                output.append("\n    - REMOVE Pancakes");
                totalPrice = totalPrice - cakesPrice;
            }
        }
     }

     private class buttonPressed implements ActionListener{
        public void actionPerformed (ActionEvent e){
            Object source = e.getSource();
            if (e.getSource() == submit) {
                System.out.print("\n\nThe 'Submit' button was pressed via 'buttonPressed' ActionListener/event");
                DecimalFormat dc = new DecimalFormat("0.00");
                String finalPrice = dc.format(totalPrice);
                output.append("\n\nTotal Price: $" + finalPrice+"\n");
            }
        }
     }
}



