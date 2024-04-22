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
          <div class="forgot-remember-container">
            <a href="#" class="forgot-password">Forget your password</a>
            <div class="checkbox">
              <input type="checkbox" id="rememberMe" v-model="rememberMe" />
              <label for="rememberMe">Remember me</label>
            </div>
          </div>
          <ButtonCard type="submit" class="ButtonCard">Log In</ButtonCard>
        </form>
        <p class="center">
          Don't have an account? <a href="#" @click="toggleMode">Register</a>
        </p>
      </template>
      <template v-else>
        <div class="center">
          <span>Register a new account</span>
        </div>
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
              :append-icon="showPassword ? 'mdi-eye' : 'mdi-eye-off'"
              @click:append="showPassword = !showPassword"
              :type="showPassword ? 'text' : 'password'"
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
          <div class="checkbox">
            <input type="checkbox" id="register" v-model="register" />
            <label for="register">Register an event organizer</label>
          </div>
          <div class="checkbox">
            <input type="checkbox" id="terms" v-model="terms" />
            <label for="terms"
              >I agree to the term <a href="#" style="bold">Eventhub</a></label
            >
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
import { ref, onMounted } from "vue";
import Card from "@/components/emsCard.vue";
import TextField from "@/components/emsTextfield.vue";
import ButtonCard from "@/components/emsCard.vue";
import { useRouter } from "vue-router";

const router = useRouter();

const mode = ref(router.currentRoute.value.params.mode || "login");
const loginData = ref({
  email: "",
  password: "",
});
const signupData = ref({
  name: "",
  email: "",
  phoneNumber: "",
  password: "",
  showPassword: false,
});
const rememberMe = ref(false);
const register = ref(false);
const terms = ref(false);
const showPassword = ref(false);

const login = () => {};

const signup = () => {};

const toggleMode = () => {
  if (mode.value === "login") {
    router.push({ name: "authUser", params: { mode: "signup" } });
  } else {
    router.push({ name: "authUser", params: { mode: "login" } });
  }
};
onMounted(() => {
  if (!router.currentRoute.value.params.mode) {
    router.replace({ name: "authUser", params: { mode: "login" } });
  }
});
</script>

<style scoped>
.center-container {
  background-image: url("@/assets/background.jpg");
  display: flex;
  align-items: center;
  height: 100vh;
}
.Card {
  border-radius: 30px;
  box-shadow: 0 4px 6px rgba(0, 0, 0, 0.1);
  padding: 30px;
  margin: 20px auto;
  width: 30%;
  color: #004b8d;
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
  background-color: #6f6fdcd0;
  color: white;
  border: none;
  border-radius: 50px;
  margin-bottom: 10px;
  padding: 10px 20px;
  cursor: pointer;
  transition: background-color 0.3s ease;
  margin-top: 10px;
  display: flex;
  justify-content: center;
  align-items: center;
  height: 50%;
}

.ButtonCard:hover {
  background-color: #ffa500;
}

.forgot-password {
  display: block;
  margin-top: 10px;
  color: #004b8d;
  text-decoration: none;
  font-weight: bold;
}

.forgot-password:hover {
  text-decoration: underline;
}

.Event {
  color: #004b8d;
}

.Hub {
  color: #ffa500;
}

.title {
  text-align: center;
  font-weight: bold;
  font-style: italic;
}

.center {
  text-align: center;
  font-size: 18px;
}

.forgot-remember-container {
  display: flex;
  justify-content: space-between;
  align-items: center;
  margin-bottom: 10px;
}

.checkbox {
  display: flex;
  align-items: center;
  color: #004b8d;
  font-size: 15px;
}
</style>
@/components/emsTextfield.vue
