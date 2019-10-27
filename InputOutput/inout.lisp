; Common Lisp language

(defun solveMeFirst (x y)    
     ;; Hint: Type (+ x y)) below
    
(setq a (read-line))
(setq b (read-line))

(write (solveMeFirst (parse-integer a) (parse-integer b)))
