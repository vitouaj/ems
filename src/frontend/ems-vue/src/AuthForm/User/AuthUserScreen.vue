<template>
  <div class="center-container">
    <Card class="Card">
      <h1 class="title">
        <span class="Event">Event</span>
        <span class="Hub">hub</span>
      </h1>
      <template v-if="mode === 'login'">
        <div class="center">
          <span>We are thrilled to have you back.</span>
        </div>
        <form @submit.prevent="login">
          <div class="form-group">
            <TextField
              id="email"
              label="Email"
              v-model="loginData.email"
              type="email"
              required
              class="TextField input"
            />
          </div>
          <div class="form-group">
            <TextField
              id="password"
              label="Password"
              v-model="loginData.password"
              type="password"
              required
            />
          </div>
          <div class="form-group">
            <TextField
              id="phoneNumber"
              label="Phone Number"
              v-model="signupData.phoneNumber"
              type="tel"
              required
            />
          </div>
          <a href="#" class="forgot-password">Forget your password</a>
          <ButtonCard type="submit" class="ButtonCard">Log In</ButtonCard>
        </form>
        <p class="center">
          Don't have an account? <a href="#" @click="toggleMode">Register</a>
        </p>
      </template>
      <template v-else>
        <span>Register a new account</span>
        <form @submit.prevent="signup">
          <div class="form-group">
            <TextField id="name" label="Full Name" v-model="signupData.name" required />
          </div>
          <div class="form-group">
            <TextField
              id="email"
              label="Email"
              v-model="signupData.email"
              type="email"
              required
            />
          </div>
          <div class="form-group">
            <TextField
              id="password"
              label="Password"
              v-model="signupData.password"
              type="password"
              required
            />
          </div>
          <div class="form-group">
            <TextField
              id="confirm-password"
              label="Confirm Password"
              v-model="signupData.password"
              type="password"
              required
            />
          </div>
          <div>
            <ButtonCard type="submit" class="ButtonCard">Sign Up</ButtonCard>
          </div>
        </form>
        <div class="center">
          <span>Already have an account? <a href="#" @click="toggleMode">Log In</a></span>
        </div>
      </template>
    </Card>
  </div>
</template>

<script setup lang="ts">
import { ref } from "vue";
import Card from "@/components/emsCard.vue";
import TextField from "@/components/emsTextfield.vue";
import ButtonCard from "@/components/emsCard.vue";

const mode = ref("login"); // Default mode is login
const loginData = ref({
  email: "",
  password: "",
});
const signupData = ref({
  name: "",
  email: "",
  phoneNumber: "",
  password: "",
});

const login = () => {
  // Your login logic here
};

const signup = () => {
  // Your signup logic here
};

const toggleMode = () => {
  mode.value = mode.value === "login" ? "signup" : "login";
};
</script>

<style scoped>
.center-container {
  background-image: url("@/assets/background.jpg");
  display: flex;
  justify-content: center;
  align-items: center;
  height: 100vh;
}
.Card {
  border-radius: 30px;
  box-shadow: 0 4px 6px rgba(0, 0, 0, 0.1);
  padding: 30px;
  margin: 20px auto;
  max-width: 1000px;
}

.form-row {
  display: flex;
  justify-content: space-between;
  margin-bottom: 15px;
}

.form-group {
  flex: 1;
  margin-right: 15px;
}

.TextField label {
  font-weight: bold;
}

.TextField input {
  width: 100%;
  padding: 10px;
  border: 1px solid #ccc;
  border-radius: 10px;
}

.ButtonCard {
  background-color: #2c64fc;
  color: white;
  border: none;
  border-radius: 50px;
  margin-bottom: 10px;
  padding: 10px 20px;
  cursor: pointer;
  transition: background-color 0.3s ease;
}

.ButtonCard:hover {
  background-color: #1f1f1f;
}

.forgot-password {
  display: block;
  margin-top: 10px;
  color: #2c64fc;
  text-decoration: none;
}

.forgot-password:hover {
  text-decoration: underline;
}

.Event {
  color: orange;
}

.Hub {
  color: blue;
}

.title {
  text-align: center;
  font-weight: bold;
  font-style: italic;
}

.center {
  text-align: center;
}
</style>
@/components/emsTextfield.vue
