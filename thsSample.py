import tkinter as tk
from tkinter import messagebox

class LoginScreen(tk.Tk):
    def __init__(self):
        super().__init__()

        self.title("Login")
        self.geometry("800x600")

        # Create a frame for the login form
        self.login_frame = tk.Frame(self, bg='white')
        self.login_frame.place(relx=0.5, rely=0.5, anchor='center')

        # Username label and entry
        self.username_label = tk.Label(self.login_frame, text="Username", bg='white')
        self.username_label.pack(pady=10)
        self.username_entry = tk.Entry(self.login_frame)
        self.username_entry.pack(pady=10)

        # Password label and entry
        self.password_label = tk.Label(self.login_frame, text="Password", bg='white')
        self.password_label.pack(pady=10)
        self.password_entry = tk.Entry(self.login_frame, show='*')
        self.password_entry.pack(pady=10)

        # Login button
        self.login_button = tk.Button(self.login_frame, text="Login", command=self.login)
        self.login_button.pack(pady=10)

    def login(self):
        username = self.username_entry.get()
        password = self.password_entry.get()

        if username and password:
            self.destroy()
            app = GateAccessSystem()
            app.mainloop()
        else:
            messagebox.showerror("Error", "Please enter both username and password")

class GateAccessSystem(tk.Tk):
    def __init__(self):
        super().__init__()

        self.title("Gate Access System")
        self.geometry("800x600")

        # Create a frame for the left side options
        self.left_frame = tk.Frame(self, width=200, bg='lightgrey')
        self.left_frame.pack(side='left', fill='y')

        # Create buttons for each option
        self.create_left_menu()

        # Create a frame for the main content area
        self.main_frame = tk.Frame(self, bg='white')
        self.main_frame.pack(side='right', fill='both', expand=True)

    def create_left_menu(self):
        buttons = [
            ("Registration Management", self.show_message),
            ("License Plate", self.capture_image),
            ("Drivers License", self.show_message),
            ("Reports", self.show_message)
        ]

        for (text, command) in buttons:
            button = tk.Button(self.left_frame, text=text, command=command, bg='lightgrey', relief='flat', anchor='w')
            button.pack(fill='x', padx=10, pady=5)

    def show_message(self):
        messagebox.showinfo("Info", "Button clicked!")
    def capture_image(self):
        frame = tk.Frame(self.main_frame, bg="lightblue", bd=5, relief=tk.RIDGE, width=600, height=500)
        frame.pack(padx=10, pady=10)
        frame.pack_propagate(False)
        label = tk.Label(frame, text="image here", bg="lightblue")
        label.pack(pady=20)

        self.login_button = tk.Button(self.main_frame, text="Login")

if __name__ == "__main__":
    login_app = LoginScreen()
    login_app.mainloop()

frame_window = tk.Toplevel(root)
    
  